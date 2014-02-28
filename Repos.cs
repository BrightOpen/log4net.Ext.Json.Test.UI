using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net.Repository;
using log4net.Core;
using log4net.Appender;
using log4net.Json.Test.UI.Appender;
using System.Web.Script.Serialization;
using log4net.Config;
using System.IO;
using log4net.Repository.Hierarchy;

namespace log4net.Json.Test.UI
{
    public partial class Repos : Form
    {
        public Repos()
        {
            InitializeComponent();

            LoadRepos();

            gbAppender.SetBounds(0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            gbLogger.SetBounds(0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            gbRepo.SetBounds(0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);

            var assembly = GetType().Assembly;
            var resourceName = GetType().Namespace + ".log4net.config";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                tbRepoConfig.Text = reader.ReadToEnd();
            }
        }


        void LoadRepos()
        {
            tvRepos.Nodes.Clear();
            gbAppender.Visible = false;
            gbLogger.Visible = false;
            gbRepo.Visible = false;

            foreach (var repo in LogManager.GetAllRepositories())
            {
                var stockRepo = repo as Hierarchy;
                var repoNode = new TreeNode(repo.Name);
                repoNode.Tag = repo;
                tvRepos.Nodes.Add(repoNode);

                tbRepoMessages.Clear();
                foreach (var msg in repo.ConfigurationMessages)
                {
                    tbRepoMessages.AppendText(String.Format("{0}\r\n", msg));
                }

                var repoAppendersNode = new TreeNode("Appenders");
                repoNode.Nodes.Add(repoAppendersNode);
                foreach (var appender in repo.GetAppenders())
                {
                    var appenderNode = new TreeNode();
                    repoAppendersNode.Nodes.Add(appenderNode);
                    LoadAppender(appenderNode, appender);
                }

                var repoLoggersNode = new TreeNode("Loggers");
                repoNode.Nodes.Add(repoLoggersNode);
                var remainingLoggers = new HashSet<ILogger>(repo.GetCurrentLoggers());

                if (stockRepo != null)
                {
                    LoadLogger(repoLoggersNode, stockRepo.Root, remainingLoggers);
                }

                foreach (var logger in remainingLoggers)
                {
                    var loggerNode = new TreeNode();
                    repoLoggersNode.Nodes.Add(loggerNode);
                    LoadLogger(loggerNode, logger, remainingLoggers);
                }

            }
            tvRepos.ExpandAll();
            tvRepos.SelectedNode = tvRepos.Nodes.OfType<TreeNode>().FirstOrDefault();
        }
        void LoadLogger(TreeNode loggerNode, ILogger logger, ISet<ILogger> remainingLoggers)
        {
            loggerNode.Text = "L: " + logger.Name;
            loggerNode.Tag = logger;
            remainingLoggers.Remove(logger);

            foreach (var childLogger in remainingLoggers.OfType<Logger>().ToArray())
            {
                if (childLogger.Parent != logger) continue;

                remainingLoggers.Remove(childLogger);
                var childLoggerNode = new TreeNode();
                loggerNode.Nodes.Add(childLoggerNode);
                LoadLogger(childLoggerNode, childLogger, remainingLoggers);
            }

            var appendersLogger = logger as IAppenderAttachable;
            if (appendersLogger != null)
            {
                foreach (var appender in appendersLogger.Appenders)
                {
                    var appenderNode = new TreeNode();
                    loggerNode.Nodes.Add(appenderNode);
                    LoadAppender(appenderNode, appender);
                }
            }
        }
        void LoadHubAppender(TreeNode appenderNode, IAppenderAttachable hubAppender)
        {
            foreach (var childAppender in hubAppender.Appenders)
            {
                var cnode = new TreeNode();
                LoadAppender(cnode, childAppender);
                appenderNode.Nodes.Add(cnode);
            }
        }

        void LoadAppender(TreeNode appenderNode, IAppender appender)
        {
            appenderNode.Text = "A: " + appender.Name;
            appenderNode.Tag = appender;

            var hubAppender = appender as IAppenderAttachable;
            if (hubAppender != null)
            {
                LoadHubAppender(appenderNode, hubAppender);
            }

        }

        private void DisplayAppender(IAppender appender, TreeNode appenderNode)
        {
            gbAppender.Visible = true;
            gbLogger.Visible = false;
            gbRepo.Visible = false;
            gbAppender.Text = "Appender " + appender.Name;
            lAppenderType.Text = appender.GetType().FullName;

            comboAppenderThresholds.Items.Clear();
            comboAppenderThresholds.Text = "unset";

            var stockAppender = appender as AppenderSkeleton;
            if (stockAppender != null)
            {
                var parent = appenderNode;
                ILoggerRepository parentRepo = null;

                while (parent != null && parentRepo == null)
                {
                    parentRepo = parent.Tag as ILoggerRepository;
                    parent = parent.Parent;
                }

                if (parentRepo != null)
                    foreach (Level level in parentRepo.LevelMap.AllLevels)
                    {
                        comboAppenderThresholds.Items.Add(level);
                    }

                if (stockAppender.Threshold != null)
                    foreach (var item in comboAppenderThresholds.Items.OfType<Level>())
                    {
                        if (item.Value == stockAppender.Threshold.Value)
                        {
                            comboAppenderThresholds.SelectedItem = item;
                            break;
                        }
                    }
            }

            var testAppender = appender as TestAppender;
            if (testAppender != null)
            {
            }
        }

        private void DisplayLogger(ILogger logger)
        {
            gbAppender.Visible = false;
            gbLogger.Visible = true;
            gbRepo.Visible = false;
            gbLogger.Text = "Logger " + logger.Name;
            lLoggerType.Text = logger.GetType().FullName;

            comboLoggerLevels.Items.Clear();
            comboLoggerLevels.Text = "unset";

            ILoggerRepository parentRepo = logger.Repository;
            var stockLogger = logger as Logger;
            if (stockLogger != null)
            {
                if (parentRepo != null)
                    foreach (Level level in parentRepo.LevelMap.AllLevels)
                    {
                        comboLoggerLevels.Items.Add(level);
                    }

                if (stockLogger.Level != null)
                    foreach (var item in comboLoggerLevels.Items.OfType<Level>())
                    {
                        if (item.Value == stockLogger.Level.Value)
                        {
                            comboLoggerLevels.SelectedItem = item;
                            break;
                        }
                    }
            }
        }

        private void DisplayRepo(ILoggerRepository repo)
        {
            gbAppender.Visible = false;
            gbLogger.Visible = false;
            gbRepo.Visible = true;
            gbRepo.Text = "Repository " + repo.Name;
        }

        void DisplayItem()
        {
            var node = tvRepos.SelectedNode;
            var obj = node == null? null : node.Tag;

            var repo = obj as ILoggerRepository;
            if (repo != null) { DisplayRepo(repo); return; }

            var logger = obj as ILogger;
            if (logger != null) { DisplayLogger(logger); return; }

            var appender = obj as IAppender;
            if (appender != null) { DisplayAppender(appender, node); return; }
 
        }

        private void tvRepos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DisplayItem();
        }


        private void bSave_Click(object sender, EventArgs e)
        {
            var appender = tvRepos.SelectedNode.Tag as AppenderSkeleton;

            if (appender == null)
            {
                MessageBox.Show(String.Format("Appender is not an AppenderSkeleton: {0}", tvRepos.SelectedNode.Tag), "Cannot serve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                appender.Threshold = comboAppenderThresholds.SelectedItem as Level;
                DisplayItem();
            }
        }

        private void bLoggerSave_Click(object sender, EventArgs e)
        {
            var logger = tvRepos.SelectedNode.Tag as Logger;

            if (logger == null)
            {
                MessageBox.Show(String.Format("Logger is not a stock Logger: {0}", tvRepos.SelectedNode.Tag), "Cannot serve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                logger.Level = comboLoggerLevels.SelectedItem as Level;
                DisplayItem();
            }
        }

        private void bSaveRepo_Click(object sender, EventArgs e)
        {
            var repo = tvRepos.SelectedNode.Tag as ILoggerRepository;

            if (repo == null)
            {
                MessageBox.Show(String.Format("Repo is not an ILoggerRepository: {0}", tvRepos.SelectedNode.Tag), "Cannot serve", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cfgbytes = Encoding.UTF8.GetBytes(tbRepoConfig.Text);
                var stream = new MemoryStream(cfgbytes);
                var messages = XmlConfigurator.Configure(repo, stream);

                foreach (var msg in messages)
                {
                    MessageBox.Show(String.Format("{0}", msg), "Configuration message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadRepos();
            }


        }


    }
}

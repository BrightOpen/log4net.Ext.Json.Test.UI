#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net.Json.Test.UI.Appender;
using log4net.Core;
using log4net.Appender;
using System.Web.Script.Serialization;
using System.Collections;

namespace log4net.Json.Test.UI
{
    public partial class TestUI : Form
    {
        JavaScriptSerializer Serializer = new JavaScriptSerializer();
        Config ReposForm;
        Generate GenerateForm;

        public TestUI()
        {
            InitializeComponent();

            lvLogs.Items.Clear();

            timerPickEvents.Start();
        }

        void UpdateView()
        {
            if (lvLogs.SelectedItems.Count == 0 && lvLogs.Items.Count != 0)
            {
                lvLogs.Items[lvLogs.Items.Count - 1].EnsureVisible();
            }

            UpdateDetail();
        }

        void UpdateDetail()
        {
            tvDetail.Nodes.Clear();
            tbEntry.Text = String.Empty;

            if (lvLogs.Items.Count != 0)
            {
                var item = lvLogs.SelectedItems.Count == 0
                        ? lvLogs.Items[lvLogs.Items.Count - 1]
                        : lvLogs.SelectedItems[0];

                var le = item.Tag as LoggingEvent;

                if (le == null)
                {
                    tvDetail.Nodes.Add(new TreeNode(String.Format("Unknown entry #{0}: {1}", item.Index, item.Tag)));
                }
                else
                {
                    var data = le.Properties["TestAppenderData"] as string;
                    if (string.IsNullOrEmpty(data)) data = le.RenderedMessage;
                    if (string.IsNullOrEmpty(data)) data = le.ToString();
                    tbEntry.Text = data;

                    try
                    {
                        var obj = Serializer.DeserializeObject(data);
                        tvDetail.Nodes.AddRange(VisualizeDict(obj as IDictionary).ToArray());
                    }
                    catch (Exception x)
                    {
                        tvDetail.Nodes.Add(new TreeNode(String.Format("Could not parse the data due to exception: {0}", x.ToString())));
                    }

                    tvDetail.Nodes.Add(new TreeNode(String.Format("Entry #{0}: {1}", item.Index, data)));

                }

                tvDetail.ExpandAll();

            }
        }

        IEnumerable<TreeNode> VisualizeDict(IDictionary dict)
        {
            foreach (DictionaryEntry entry in dict)
            {
                var node = new TreeNode(Convert.ToString(entry.Key));
                var nesteddict = entry.Value as IDictionary;
                if (nesteddict == null)
                {
                    node.Text = String.Format("{0} = {1}", entry.Key, entry.Value);
                }
                else
                {
                    node.Nodes.AddRange(VisualizeDict(nesteddict).ToArray());
                }
                yield return node;
            }
        }

        private void bFollow_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLogs.SelectedItems)
            {
                item.Selected = false;
            }
            UpdateView();
        }

        private void lvLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lvLogs.Items.Clear();
            UpdateView();
        }


        private void bConfig_Click(object sender, EventArgs e)
        {
            var repos = ReposForm;

            if (repos == null || repos.IsDisposed)
            {
                ReposForm = repos = new Config();
            }

            repos.Show();
            repos.Select();

            if (repos.WindowState == FormWindowState.Minimized) repos.WindowState = FormWindowState.Normal;
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            var form = GenerateForm;

            if (form == null || form.IsDisposed)
            {
                GenerateForm = form = new Generate();
            }

            form.Show();
            form.Select();

            if (form.WindowState == FormWindowState.Minimized) form.WindowState = FormWindowState.Normal;

        }


        void TestAppender_Appended(IAppender appender, LoggingEvent loggingEvent, string entry)
        {
        }
        private void timerPickEvents_Tick(object sender, EventArgs e)
        {
            var events = TestAppender.GetEvents().ToArray();

            if (events.Length != 0)
            {
                var lvitems = (from le in events
                               select new ListViewItem(
                                     new string[] { 
                                    le.TimeStamp.ToString("u"), 
                                    le.Level.DisplayName, 
                                    le.LoggerName, 
                                    le.ThreadName, 
                                    le.RenderedMessage,
                                    Convert.ToString(le.Properties["TestAppender"]) 
                                })
                                     {
                                         Tag = le
                                     }
                              ).ToArray();

                var textupdatecall = new Action(() => { lvLogs.Items.AddRange(lvitems); UpdateView(); });

                if (lvLogs.InvokeRequired)
                    lvLogs.Invoke(textupdatecall);
                else
                    textupdatecall();
            }

            lCount.Text = lvLogs.Items.Count.ToString("###,###,###");
        }


    }
}

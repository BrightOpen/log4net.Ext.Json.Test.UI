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
        Repos ReposForm;

        public TestUI()
        {
            InitializeComponent();

            TestAppender.Appended += TestAppender_Appended;

            lvLogs.Items.Clear();
        }

        void TestAppender_Appended(IAppender appender, LoggingEvent loggingEvent, string entry)
        {
            var textupdatecall = new Action(() => { UpdateText(entry); });

            if (lvLogs.InvokeRequired)
                lvLogs.Invoke(textupdatecall);
            else
                textupdatecall();
        }

        void UpdateText(string entry)
        {
            lvLogs.Items.Add(entry);

            if (lvLogs.SelectedItems.Count == 0 && lvLogs.Items.Count != 0)
            {
                lvLogs.Items[lvLogs.Items.Count - 1].EnsureVisible();
                UpdateDetail();
            }
        }

        void UpdateDetail()
        {
            tvDetail.Nodes.Clear();

            if (lvLogs.Items.Count != 0)
            {
                var item = lvLogs.SelectedItems.Count == 0
                        ? lvLogs.Items[lvLogs.Items.Count - 1]
                        : lvLogs.SelectedItems[0];

                tbEntry.Text = item.Text;

                tvDetail.Nodes.Add(new TreeNode(String.Format("Entry #{0}", item.Index)));
                var obj = Serializer.DeserializeObject(item.Text);
                tvDetail.Nodes.AddRange(VisualizeDict(obj as IDictionary).ToArray());
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
            UpdateDetail();
        }

        private void lvLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }


        private void bConfig_Click(object sender, EventArgs e)
        {
            var repos = ReposForm;

            if (repos == null || repos.IsDisposed)
            {
                ReposForm = repos = new Repos();
            }

            repos.Show();
            repos.Select();

            if (repos.WindowState == FormWindowState.Minimized) repos.WindowState = FormWindowState.Normal;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lvLogs.Items.Clear();
            UpdateDetail();
        }


    }
}

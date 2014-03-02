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
        Receive ReceiveForm;

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
                GetListItem().EnsureVisible();
            }

            UpdateDetail();
        }

        void UpdateDetail()
        {
            tvDetail.Nodes.Clear();
            tbEntry.Text = String.Empty;

            var item = GetListItem();
            var le = GetListEvent(item);
            var data = GetListData(item);

            if (item == null) return;

            if (le == null)
            {
                tvDetail.Nodes.Add(new TreeNode(String.Format("Unknown entry #{0}: {1}", item.Index, item.Tag)));
            }
            else
            {
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
        private void bReceive_Click(object sender, EventArgs e)
        {
            var form = ReceiveForm;

            if (form == null || form.IsDisposed)
            {
                ReceiveForm = form = new Receive();
            }

            form.Show();
            form.Select();

            if (form.WindowState == FormWindowState.Minimized) form.WindowState = FormWindowState.Normal;


        }


        private void timerPickEvents_Tick(object sender, EventArgs e)
        {
            var events = TestAppender.GetEvents().ToArray();
            var lvitems = new List<ListViewItem>(events.Length);

            if (events.Length != 0)
            {
                foreach (var le in events)
                {
                    lvitems.Add(new ListViewItem(
                                     new string[] { 
                                    le.TimeStamp.ToString("u"), 
                                    le.Level.DisplayName, 
                                    le.LoggerName, 
                                    le.ThreadName, 
                                    le.RenderedMessage,
                                    Convert.ToString(le.Properties["TestAppender"]) ,
                                    Convert.ToString(le.Properties["TestAppenderData"]) ,
                                })
                                     {
                                         Tag = le
                                     });

                    le.Properties.Remove("TestAppender");
                    le.Properties.Remove("TestAppenderData");
                }

                var textupdatecall = new Action(() => { lvLogs.Items.AddRange(lvitems.ToArray()); UpdateView(); });

                if (lvLogs.InvokeRequired)
                    lvLogs.Invoke(textupdatecall);
                else
                    textupdatecall();
            }

            lCount.Text = lvLogs.Items.Count.ToString("###,###,###");
        }

        private void tbEntry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectAllText();
        }

        private void tbEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                SelectAllText();
            }
            else if (e.Control && e.KeyCode.ToString() == "C")
            {
                if (tbEntry.SelectionLength == 0)
                    Clipboard.SetText(tbEntry.Text);
            }
        }

        void SelectAllText()
        {
            tbEntry.SelectionStart = 0;
            tbEntry.SelectionLength = tbEntry.TextLength;
        }

        private void copyOneLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetListData();

            Clipboard.SetText(data);
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            foreach (ListViewItem lvitem in lvLogs.Items)
            {
                sb.Append(GetListData(lvitem));
            }

            Clipboard.SetText(sb.ToString());
        }

        private void copyAllInArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            bool has = false;

            foreach (ListViewItem lvitem in lvLogs.Items)
            {
                if (has) sb.Append(",");
                has = true;
                sb.Append(GetListData(lvitem));
            }
            sb.AppendLine("]");

            Clipboard.SetText(sb.ToString());
        }

        protected String GetListData(ListViewItem lvitem = null)
        {
            lvitem = lvitem ?? GetListItem();

            if (lvitem == null) return null;

            var data = lvitem.SubItems[colTestAppenderData.Index].Text;
            
            var le = GetListEvent(lvitem);
            if (le != null)
            {
                if (string.IsNullOrEmpty(data)) data = le.RenderedMessage;
                if (string.IsNullOrEmpty(data)) data = le.ToString();
            }

            return data;
        }

        protected LoggingEvent GetListEvent(ListViewItem lvitem = null)
        {
            lvitem = lvitem ?? GetListItem();

            if (lvitem == null) return null;

            return lvitem.Tag as LoggingEvent;
        }

        protected ListViewItem GetListItem()
        {
            var lvitem =
                   (lvLogs.SelectedItems.Count > 0
                   ? lvLogs.SelectedItems[0]
                   : lvLogs.Items.Count > 0
                   ? lvLogs.Items[lvLogs.Items.Count - 1]
                   : null
                   );

            return lvitem;
        }

    }
}

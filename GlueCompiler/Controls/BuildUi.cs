using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlueCompiler.Builders;
using FlatRedBall.Glue;
using System.IO;

namespace GlueCompiler.Controls
{
    public partial class BuildUi : UserControl
    {
        public const int TYPE_COLUMN = 0;
        public const int MESSAGE_COLUMN = 1;
        public const int LINE_NUM_COLUMN = 2;
        public const int FILE_COLUMN = 3;
        public const int PROJECT_COLUMN = 4;

        private BuildProcessor _builder;
        private IEnumerable<BuildMessage> _lastBuildMessages;
        private BuildMessageListViewSorter _sorter;
        private bool _dataLoading;

        public BuildUi()
        {
            _builder = new BuildProcessor(CompileCompletedHandler);
            _sorter = new BuildMessageListViewSorter();
            InitializeComponent();
        }

        private void BuildUi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cmbBuildType.SelectedIndex = 0;
            lstMessages.ListViewItemSorter = _sorter;
            DisableToggles();
            lblCompileMessage.Visible = false;
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            string directory = ProjectManager.ProjectRootDirectory;
            string solution = Directory.GetFiles(directory).FirstOrDefault(x => x.EndsWith(".sln"));
            if (solution == null)
            {
                MessageBox.Show("No solution found in " + directory, "Error", MessageBoxButtons.OK);
                return;
            }

            DisableToggles();
            lstMessages.Items.Clear();
            _lastBuildMessages = null;
            lblCompileMessage.Visible = true;
            btnCompile.Enabled = false;

            _builder.StartCompile(solution, cmbBuildType.SelectedItem as string);
        }

        private void lstMessages_KeyDown(object sender, KeyEventArgs e)
        {
            // Copy support
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (lstMessages.SelectedItems.Count == 0)
                    return;

                var text = new StringBuilder();
                foreach (ListViewItem item in lstMessages.SelectedItems)
                {
                    for (int x = 0; x < item.SubItems.Count; x++)
                    {
                        if (x > 0)
                            text.Append("\t");

                        text.Append(item.SubItems[x].Text);
                    }

                    if (lstMessages.SelectedItems[lstMessages.SelectedItems.Count - 1] != item)
                        text.Append(Environment.NewLine);
                }

                Clipboard.SetText(text.ToString());
            }
            
            // Select all support
            else if (e.Control && e.KeyCode == Keys.A)
            {
                foreach (ListViewItem item in lstMessages.Items)
                    item.Selected = true;
            }
        }

        private void ToggleButtonsCheckedChange(object sender, EventArgs e)
        {
            if (_dataLoading)
                return;

            DisplayMessages(_lastBuildMessages);
        }

        private void DisplayMessages(IEnumerable<BuildMessage> messages)
        {
            lstMessages.Items.Clear();

            // Filter based on the checked items
            var queryable = _lastBuildMessages.AsQueryable();
            if (!chkShowErrors.Checked)
                queryable = queryable.Where(x => x.Type != BuildMessageType.Error);

            if (!chkShowWarnings.Checked)
                queryable = queryable.Where(x => x.Type != BuildMessageType.Warning);

            messages = queryable.ToArray();

            foreach (var message in messages)
            {
                var project = message.Project;
                if (!string.IsNullOrWhiteSpace(project) && project.LastIndexOf("\\") >= 0)
                    project = project.Substring(project.LastIndexOf("\\") + 1);

                lstMessages.Items.Add(new ListViewItem(new string[]
                {
                    message.Type.ToString(),
                    message.Message,
                    message.LineNumber.ToString(),
                    message.File,
                    project
                }));
            }
        }

        private void DisableToggles()
        {
            chkShowErrors.Visible = false;
            chkShowWarnings.Visible = false;
        }

        private void EnableToggles()
        {
            _dataLoading = true;

            chkShowErrors.Visible = true;
            chkShowErrors.Checked = true;
            chkShowWarnings.Visible = true;
            chkShowWarnings.Checked = true;

            _dataLoading = false;
        }

        private void SetToggleText()
        {
            int errorCount = _lastBuildMessages.Count(x => x.Type == BuildMessageType.Error);
            int warningCount = _lastBuildMessages.Count(x => x.Type == BuildMessageType.Warning);

            chkShowErrors.Text = errorCount + " Errors";
            chkShowWarnings.Text = warningCount + " Warnings";
        }

        private void CompileCompletedHandler(IEnumerable<BuildMessage> results)
        {
            // If this is not called on the UI thread, re-call it on the correct thread
            if (InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { CompileCompletedHandler(results); });
                return;
            }

            try
            {
                _lastBuildMessages = results;

                // If no messages then the build was successful
                if (_lastBuildMessages.Count() == 0)
                {
                    _lastBuildMessages = new BuildMessage[]
                    {
                        new BuildMessage { Type = BuildMessageType.Success, Message = "Your project built successfully" }
                    };
                }
            }
            catch (Exception ex)
            {
                string message = string.Format("An {0} occurred when displaying results: {1}", ex.GetType(), ex.Message);
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EnableToggles();
            SetToggleText();
            DisplayMessages(_lastBuildMessages);
            lblCompileMessage.Visible = false;
            btnCompile.Enabled = true;
        }
    }
}
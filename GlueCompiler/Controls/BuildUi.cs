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
        private BuildProcessor _builder;

        public BuildUi()
        {
            _builder = new BuildProcessor();
            InitializeComponent();
        }

        private void BuildUi_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            cmbBuildType.SelectedIndex = 0;
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();

            string directory = ProjectManager.ProjectRootDirectory;
            string solution = Directory.GetFiles(directory).FirstOrDefault(x => x.EndsWith(".sln"));
            if (solution == null)
            {
                MessageBox.Show("No solution found in " + directory, "Error", MessageBoxButtons.OK);
                return;
            }

            _builder = new BuildProcessor();
            var messages = _builder.Run(solution, cmbBuildType.SelectedItem as string);
            foreach (var message in messages)
            {
                lstMessages.Items.Add(new ListViewItem(new string[]
                {
                    message.Type.ToString(),
                    message.Message,
                    message.LineNumber.ToString(),
                    message.File,
                    message.Project
                }));
            }

            // If no messages then the build was successful
            if (messages.Count() == 0)
            {
                lstMessages.Items.Add(new ListViewItem(new string[]
                {
                    "Success",
                    "Project was successfully compiled"
                }));
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazel_GUI
{
    public partial class WorkspaceSettingsForm : Form
    {
        public string projectPath = "";
        public string projectName = "";
        public ArrayList projectBuildPath = new ArrayList();

        public int projectCount = 0;

        public WorkspaceSettingsForm()
        {
            InitializeComponent();
        }

        private void WorkspaceSettingsForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < projectCount; i++)
            {
                Button projectNameB = new Button();
                projectNameB.Tag = i;
                projectNameB.Text = $"{projectName}" + $"{i}";
                projectListFL.Controls.Add(projectNameB);
                projectNameB.Click += projectNameB_Click;
            }
        }

        private void projectNameB_Click(object sender, EventArgs e)
        {
            BUILDbazel BUILDbazel = new BUILDbazel();
            Button btnSender = (Button)sender;

            int tag = Convert.ToInt32(((Button)sender).Tag);

            MessageBox.Show((string)projectBuildPath[tag]);
            BUILDbazel.BUILDbazelName = projectName;
            BUILDbazel.BUILDbazelPath = (string)projectBuildPath[tag];
            BUILDbazel.ShowDialog();
        }
    }
}

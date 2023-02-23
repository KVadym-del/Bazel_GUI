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
using static System.Windows.Forms.DataFormats;

namespace Bazel_GUI
{
    public partial class WorkspaceSettingsForm : Form
    {
        public string projectPath = string.Empty;
        public List<String> projectName = new List<String>();
        public ArrayList projectBuildPath = new ArrayList();

        public int projectCount = 0;

        public WorkspaceSettingsForm()
        {
            InitializeComponent();
        }

        private void WorkspaceSettingsForm_Load(object sender, EventArgs e)
        {
            projectCount = projectName.Count;
            for (int i = 0; i < projectCount; i++)
            {
                
                Button projectNameB = new Button();
                projectNameB.Margin = new System.Windows.Forms.Padding(4);
                projectNameB.Size = new System.Drawing.Size(400, 25);
                projectNameB.Tag = i;
                projectNameB.Text = $"{projectName[i]}";
                projectListFL.Controls.Add(projectNameB);
                projectNameB.Click += projectNameB_Click;
            }
        }

        private void projectNameB_Click(object sender, EventArgs e)
        {
            BUILDbazel BUILDbazel = new BUILDbazel();
            Button btnSender = (Button)sender;

            int tag = Convert.ToInt32(((Button)sender).Tag);

            MessageBox.Show((string)projectName[tag]);
            BUILDbazel.BUILDbazelName = projectName[tag];
            BUILDbazel.BUILDbazelPath = (string)projectName[tag];
            BUILDbazel.ShowDialog();
        }

        private void WorkspaceSettingsForm_FormClosing(object sender, EventArgs e)
        {
            projectCount = 0;
            projectName.Clear();
            projectBuildPath.Clear();
            projectPath = string.Empty;
            projectListFL.Controls.Clear();
        }
    }
}

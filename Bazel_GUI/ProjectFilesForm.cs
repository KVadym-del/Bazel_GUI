using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bazel_GUI {
    public partial class ProjectFilesForm : Form {
        public string projectPath = string.Empty;
        private string[] filePaths;
        private List<String> projectFilesNames = new List<String>();

        private int BCount;

        public ProjectFilesForm() {
            InitializeComponent();
        }

        private void ProjectFilesForm_Load(object sender, EventArgs e) {
            filePaths = Directory.GetFiles(projectPath, "*.cpp", SearchOption.TopDirectoryOnly);

            DirectoryInfo d = new DirectoryInfo(projectPath); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.cpp"); //Getting Text files
            int count = 0;
            foreach (FileInfo file in Files) {
                projectFilesNames.Add(file.Name);
                count++;
            }

            //MessageBox.Show($"{filePaths[0]}\n{projectFilesNames[0]}");

            for (BCount = 0; BCount < projectFilesNames.Count; BCount++) {
                System.Windows.Forms.Button projectNameB = new System.Windows.Forms.Button();
                projectNameB.Margin = new System.Windows.Forms.Padding(4);
                projectNameB.Size = new System.Drawing.Size(400, 25);
                projectNameB.Tag = BCount;
                projectNameB.Text = $"{projectFilesNames[BCount]}";
                fileListFL.Controls.Add(projectNameB);
                projectNameB.Click += projectNameB_Click;
            }
        }

        private void projectNameB_Click(object sender, EventArgs e) {
            BUILDbazel BUILDbazel = new BUILDbazel();
            System.Windows.Forms.Button btnSender = (System.Windows.Forms.Button)sender;

            int tag = Convert.ToInt32(((System.Windows.Forms.Button)sender).Tag);

            MessageBox.Show((string)projectFilesNames[tag]);
            BUILDbazel.BUILDbazelName = projectFilesNames[tag];
            BUILDbazel.BUILDbazelPath = (string)filePaths[tag];
            BUILDbazel.ShowDialog();
        }

    }
}

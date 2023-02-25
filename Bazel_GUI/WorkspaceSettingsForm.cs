namespace Bazel_GUI {

    public partial class WorkspaceSettingsForm : Form {
        public string projectPath = string.Empty;
        public List<String> projectName = new List<String>();
        public List<String> projectBuildPath = new List<String>();
        public List<bool> ifProject = new List<bool>();

        private int BCount = 0;

        public WorkspaceSettingsForm() {
            InitializeComponent();
        }

        private void WorkspaceSettingsForm_Load(object sender, EventArgs e) {
            for (BCount = 0; BCount < projectBuildPath.Count; BCount++) {
                CreatButton(BCount);
            }
        }

        private void projectNameB_Click(object sender, EventArgs e) {
            int tag = Convert.ToInt32(((Button)sender).Tag);
            if (ifProject[tag] == true) {
                ProjectFilesForm ProjectFilesForm = new ProjectFilesForm();
                Button btnSender = (Button)sender;

                //int tag = Convert.ToInt32(((Button)sender).Tag);

                //MessageBox.Show(GetUntilOrEmpty(projectBuildPath[tag]));
                ProjectFilesForm.projectPath = GetUntilOrEmpty(projectBuildPath[tag]);

                ProjectFilesForm.ShowDialog();
            }
            else {
                BUILDbazel BUILDbazel = new BUILDbazel();
                Button btnSender = (Button)sender;

                //int tag = Convert.ToInt32(((Button)sender).Tag);

                MessageBox.Show((string)projectName[tag]);
                BUILDbazel.BUILDbazelName = projectName[tag];
                BUILDbazel.BUILDbazelPath = (string)projectBuildPath[tag];
                BUILDbazel.ShowDialog();
            }
        }

        private void WorkspaceSettingsForm_FormClosing(object sender, EventArgs e) {
            ifProject.Clear();
            projectName.Clear();
            projectBuildPath.Clear();
            projectPath = string.Empty;
            projectListFL.Controls.Clear();
        }

        private void CreateProjectB_Click(object sender, EventArgs e) {
            CreatButton(BCount);
        }

        private void CreatButton(int BCountF) {
            if (ifProject[BCountF] == true) {
                Button projectNameB = new Button();
                projectNameB.Margin = new System.Windows.Forms.Padding(4);
                projectNameB.Size = new System.Drawing.Size(400, 25);
                projectNameB.Tag = BCountF;
                projectNameB.Text = $"{projectName[BCountF]}";
                projectListFL.Controls.Add(projectNameB);
                projectNameB.Click += projectNameB_Click;

                Button projectSettingsB = new Button();
                projectSettingsB.Margin = new System.Windows.Forms.Padding(4);
                projectSettingsB.Size = new System.Drawing.Size(100, 25);
                projectSettingsB.Tag = BCountF;
                projectSettingsB.Text = "...";
                projectListFL.Controls.Add(projectSettingsB);
                projectSettingsB.Click += projectNameB_Click;
            }
            else {
                Button projectNameB = new Button();
                projectNameB.Margin = new System.Windows.Forms.Padding(4);
                projectNameB.Size = new System.Drawing.Size(400, 25);
                projectNameB.Tag = BCountF;
                projectNameB.Text = $"{projectName[BCountF]}";
                projectListFL.Controls.Add(projectNameB);
                projectNameB.Click += projectNameB_Click;
            }
        }

        private string GetUntilOrEmpty(string MYtext, string stopAt = "BUILD.bazel") {
            if (!String.IsNullOrWhiteSpace(MYtext)) {
                int charLocation = MYtext.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0) {
                    return MYtext.Substring(0, charLocation);
                }
            }

            return String.Empty;
        }
    }
}
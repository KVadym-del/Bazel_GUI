namespace Bazel_GUI {

    public partial class WorkspaceSettingsForm : Form {
        public string projectPath = string.Empty;
        public List<String> projectName = new List<String>();
        public List<String> projectBuildPath = new List<String>();

        private int BCount = 0;

        public WorkspaceSettingsForm() {
            InitializeComponent();
        }

        private void WorkspaceSettingsForm_Load(object sender, EventArgs e) {
            for (BCount = 0; BCount < projectBuildPath.Count; BCount++) {
                CreatButton();
            }
        }

        private void projectNameB_Click(object sender, EventArgs e) {
            BUILDbazel BUILDbazel = new BUILDbazel();
            Button btnSender = (Button)sender;

            int tag = Convert.ToInt32(((Button)sender).Tag);

            MessageBox.Show((string)projectName[tag]);
            BUILDbazel.BUILDbazelName = projectName[tag];
            BUILDbazel.BUILDbazelPath = (string)projectBuildPath[tag];
            BUILDbazel.ShowDialog();
        }

        private void WorkspaceSettingsForm_FormClosing(object sender, EventArgs e) {
            projectName.Clear();
            projectBuildPath.Clear();
            projectPath = string.Empty;
            projectListFL.Controls.Clear();
        }

        private void CreateProjectB_Click(object sender, EventArgs e) {
            CreatButton();
        }

        private void CreatButton() {
            Button projectNameB = new Button();
            projectNameB.Margin = new System.Windows.Forms.Padding(4);
            projectNameB.Size = new System.Drawing.Size(400, 25);
            projectNameB.Tag = BCount;
            projectNameB.Text = $"{projectName[BCount]}";
            projectListFL.Controls.Add(projectNameB);
            projectNameB.Click += projectNameB_Click;
        }
    }
}
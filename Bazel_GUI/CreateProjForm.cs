namespace Bazel_GUI {

    public partial class CreateProjForm : Form {
        private WorkspaceSettingsForm WorkspaceSettingsForm = new WorkspaceSettingsForm();

        public CreateProjForm() {
            InitializeComponent();
        }

        public string projectName = string.Empty;

        private void CreateProjectB_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(ProjectNameT.Text)) {
                MessageBox.Show("Please paste a project name");
                return;
            }
            else {
                projectName = ProjectNameT.Text;
            }

            if (LanguageListB.SelectedIndex == -1) {
                MessageBox.Show("Please select a value");
                return;
            }

            //ring FilePath3 = $"{WorkspaceSettingsForm.projectName}\projects\\{projectName}\\BUILD.bazel";
            //ring FilePath4 = $"{workspacePath}\\projects\\{projectName}\\main.cpp";
        }

        private void CreateProjForm_Load(object sender, EventArgs e) {
            LanguageListB.Items.Clear();
            LanguageListB.Items.Add("c++");
            LanguageListB.SelectedIndex = 0;
        }
    }
}
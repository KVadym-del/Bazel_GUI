namespace Bazel_GUI {

    public partial class MainForm : Form {
        private CreateWorksForm CreateWorksForm = new CreateWorksForm();
        private WorkspaceSettingsForm WorkspaceSettingsForm = new WorkspaceSettingsForm();

        public MainForm() {
            InitializeComponent();
        }

        private void CreateProjectTB_Click(object sender, EventArgs e) {
            CreateWorksForm.ShowDialog();
            WorkspaceSettingsForm.projectPath = CreateWorksForm.workspacePath;

            if (!string.IsNullOrEmpty(CreateWorksForm.workspacePath)) {
                foreach (string line in System.IO.File.ReadLines($"{CreateWorksForm.workspacePath}\\.BazelGUI")) {
                    if (line.Contains("\t")) {
                        WorkspaceSettingsForm.ifProject.Add(true);
                        WorkspaceSettingsForm.projectName.Add(line.Substring(line.LastIndexOf('\t') + 1));
                        WorkspaceSettingsForm.projectBuildPath.Add(GetUntilOrEmpty(line));
                    }
                    else if (line.Contains(".bazelversion")) {
                        WorkspaceSettingsForm.projectName.Add(".bazelversion");
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                    else if (line.Contains("WORKSPACE.bazel")) {
                        WorkspaceSettingsForm.projectName.Add("WORKSPACE.bazel");
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                    else {
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.projectName.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                }
            }
            else {
                return;
            }

            ProjectLocationT.Text = CreateWorksForm.workspacePath;

            WorkspaceSettingsForm.ShowDialog();
        }

        private void OpenProjectTB_Click(object sender, EventArgs e) {
            string WorkspacePath = String.Empty;
            string lineText = String.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Workspace File (*.BazelGUI)|*.BazelGUI";
            if (DialogResult.OK == dialog.ShowDialog()) {
                WorkspacePath = dialog.FileName;
            }
            if (!string.IsNullOrEmpty(WorkspacePath)) {
                foreach (string line in System.IO.File.ReadLines($"{WorkspacePath}")) {
                    if (line.Contains("\t")) {
                        WorkspaceSettingsForm.ifProject.Add(true);
                        WorkspaceSettingsForm.projectName.Add(line.Substring(line.LastIndexOf('\t') + 1));
                        WorkspaceSettingsForm.projectBuildPath.Add(GetUntilOrEmpty(line));
                    }
                    else if (line.Contains(".bazelversion")) {
                        WorkspaceSettingsForm.projectName.Add(".bazelversion");
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                    else if (line.Contains("WORKSPACE.bazel")) {
                        WorkspaceSettingsForm.projectName.Add("WORKSPACE.bazel");
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                    else {
                        WorkspaceSettingsForm.projectBuildPath.Add(line);
                        WorkspaceSettingsForm.projectName.Add(line);
                        WorkspaceSettingsForm.ifProject.Add(false);
                    }
                }
            }
            else {
                return;
            }

            //WorkspaceSettingsForm.projectPath =

            ProjectLocationT.Text = WorkspacePath;

            WorkspaceSettingsForm.ShowDialog();
        }

        private string GetUntilOrEmpty(string MYtext, string stopAt = "\t") {
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
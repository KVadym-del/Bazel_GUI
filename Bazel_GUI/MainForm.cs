using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Forms;

namespace Bazel_GUI
{
    public partial class MainForm : Form
    {
        CreateProjForm CreateProjForm = new CreateProjForm();
        WorkspaceSettingsForm WorkspaceSettingsForm = new WorkspaceSettingsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateProjectTB_Click(object sender, EventArgs e)
        {
            CreateProjForm.ShowDialog();
            WorkspaceSettingsForm.projectPath = CreateProjForm.workspacePath;
            WorkspaceSettingsForm.projectBuildPath.Add(CreateProjForm.projectBuildPathM);

            if (!string.IsNullOrEmpty(CreateProjForm.workspacePath))
            {
                foreach (string line in System.IO.File.ReadLines($"{CreateProjForm.workspacePath}\\.BazelGUI"))
                {
                    //ProjectCount++;
                    WorkspaceSettingsForm.projectName.Add(line);
                }
            }
            else
            {
                return;
            }

            ProjectLocationT.Text = CreateProjForm.workspacePath;

            //WorkspaceSettingsForm.projectCount = ProjectCount;

            WorkspaceSettingsForm.ShowDialog();
        }

        private void OpenProjectTB_Click(object sender, EventArgs e)
        {
            string WorkspacePath = String.Empty;
            string lineText = String.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Workspace File (*.BazelGUI)|*.BazelGUI";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                WorkspacePath = dialog.FileName;
            }
            if (!string.IsNullOrEmpty(WorkspacePath))
            {
                //file = new System.IO.StreamReader($"{WorkspacePath}");
                foreach (string line in System.IO.File.ReadLines($"{WorkspacePath}")) {
                    WorkspaceSettingsForm.projectName.Add(line);
                }
            }
            else
            {
                return;
            }

            ProjectLocationT.Text = WorkspacePath;

            //WorkspaceSettingsForm.projectCount = ProjectCount;

            WorkspaceSettingsForm.ShowDialog();
        }
    }
}
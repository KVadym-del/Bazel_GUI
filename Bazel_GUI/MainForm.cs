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
            WorkspaceSettingsForm.projectPath = CreateProjForm.folderPath;
            WorkspaceSettingsForm.projectName = CreateProjForm.projectName;
            WorkspaceSettingsForm.projectBuildPath.Add(CreateProjForm.projectBuildPathM);

            ProjectLocationT.Text = CreateProjForm.folderPath;

            int ProjectCount = -1;

            foreach (string line in System.IO.File.ReadLines($"{CreateProjForm.folderPath}\\.BazelGUI"))
            {
                ProjectCount++;
            }

            WorkspaceSettingsForm.projectCount = ProjectCount;

            WorkspaceSettingsForm.ShowDialog();
        }

        private void OpenProjectTB_Click(object sender, EventArgs e)
        {
            string WorkspacePath = "";
            string lineText;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Workspace File (*.BazelGUI)|*.BazelGUI";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                WorkspacePath = dialog.FileName;
            }

            System.IO.StreamReader file = new System.IO.StreamReader($"{WorkspacePath}");
            while ((lineText = file.ReadLine()) != null)
            {
                WorkspaceSettingsForm.projectBuildPath.Add(lineText);
            }

            file.Close();

            int ProjectCount = 0;

            foreach (string line in System.IO.File.ReadLines($"{WorkspacePath}"))
            {
                ProjectCount++;
            }

            ProjectLocationT.Text = WorkspacePath;

            //WorkspaceSettingsForm.projectName = "Main"; // Temporary

            WorkspaceSettingsForm.projectCount = ProjectCount;

            WorkspaceSettingsForm.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Bazel_GUI
{
    public partial class CreateProjForm : Form
    {
        public CreateProjForm()
        {
            InitializeComponent();

        }

        public string workspacePath = string.Empty;
        public string projectName = string.Empty;
        public string projectBuildPathM = string.Empty;

        private void SelectFolderB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                workspacePath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            FolderPathT.Text = workspacePath;
        }

        private void CreateProjectB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProjectNameT.Text))
            {
                MessageBox.Show("Please paste a project name");
                return;
            }
            else
            {
                projectName = ProjectNameT.Text;
            }

            if (LanguageListB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value");
                return;
            }

            if (!string.IsNullOrEmpty(workspacePath))
            {
                string FilePath0 = $"{workspacePath}\\.BazelGUI";
                string FilePath1 = $"{workspacePath}\\.bazelversion";
                string FilePath2 = $"{workspacePath}\\WORKSPACE.bazel";
                string FilePath3 = $"{workspacePath}\\projects\\{projectName}\\BUILD.bazel";
                string FilePath4 = $"{workspacePath}\\projects\\{projectName}\\main.cpp";

                projectBuildPathM = FilePath3;

                System.IO.Directory.CreateDirectory($"{workspacePath}\\projects\\{projectName}");

                FileStream BazelGUI = new FileStream(FilePath0, FileMode.Create);
                FileStream bazelversion = new FileStream(FilePath1, FileMode.Create);
                FileStream WORKSPACE = new FileStream(FilePath2, FileMode.Create);
                FileStream BUILD = new FileStream(FilePath3, FileMode.Create);
                FileStream main = new FileStream(FilePath4, FileMode.Create);
                BazelGUI.Close();
                bazelversion.Close();
                WORKSPACE.Close();
                BUILD.Close();
                main.Close();

                File.AppendAllText(FilePath0, $"{FilePath2}\r\n{FilePath3}");
                File.AppendAllText(FilePath4, "#include <iostream>\r\n\r\nint main(void) {\r\n\treturn 0;\r\n}");

                if (LanguageListB.SelectedIndex == 0)
                {
                    string cxxBuildSTD = "# cc_library(name = \"hello-greet\", srcs = [\"hello-greet.cc\"], hdrs = [\"hello-greet.h\"],) -- library\r\n\r\ncc_binary(\r\n    name = \"main\",\r\n    srcs = [\"main.cpp\"],\r\n    # deps = [ \":hello-greet\" ],  -- add library\r\n)";
                    File.AppendAllText(FilePath3, cxxBuildSTD);
                }
             
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C cd {workspacePath} && bazel build //...";
                process.StartInfo = startInfo;
                process.Start();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please paste chose folder path");
                return;
            }
        }

        private void CreateProjForm_Load(object sender, EventArgs e)
        {
            LanguageListB.Items.Clear();
            LanguageListB.Items.Add("c++");      
        }
    }
}

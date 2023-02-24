namespace Bazel_GUI {
    partial class WorkspaceSettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            projectListFL = new FlowLayoutPanel();
            CreateProjectB = new Button();
            SuspendLayout();
            // 
            // projectListFL
            // 
            projectListFL.AllowDrop = true;
            projectListFL.Location = new Point(12, 50);
            projectListFL.Name = "projectListFL";
            projectListFL.Size = new Size(776, 388);
            projectListFL.TabIndex = 0;
            // 
            // CreateProjectB
            // 
            CreateProjectB.Location = new Point(12, 12);
            CreateProjectB.Name = "CreateProjectB";
            CreateProjectB.Size = new Size(168, 32);
            CreateProjectB.TabIndex = 1;
            CreateProjectB.Text = "Create Project";
            CreateProjectB.UseVisualStyleBackColor = true;
            CreateProjectB.Click += CreateProjectB_Click;
            // 
            // WorkspaceSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateProjectB);
            Controls.Add(projectListFL);
            Name = "WorkspaceSettingsForm";
            Text = "WorkspaceSettingsForm";
            FormClosing += WorkspaceSettingsForm_FormClosing;
            Load += WorkspaceSettingsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel projectListFL;
        private Button CreateProjectB;
    }
}
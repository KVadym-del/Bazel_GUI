namespace Bazel_GUI {
    partial class ProjectFilesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectFilesForm));
            fileListFL = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // fileListFL
            // 
            fileListFL.Location = new Point(12, 49);
            fileListFL.Name = "fileListFL";
            fileListFL.Size = new Size(776, 389);
            fileListFL.TabIndex = 0;
            // 
            // ProjectFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fileListFL);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProjectFilesForm";
            Text = "Project Files";
            Load += ProjectFilesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fileListFL;
    }
}
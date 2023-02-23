namespace Bazel_GUI
{
    partial class WorkspaceSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            projectListFL = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectListFL
            // 
            projectListFL.Location = new Point(12, 60);
            projectListFL.Name = "projectListFL";
            projectListFL.Size = new Size(776, 378);
            projectListFL.TabIndex = 0;
            // 
            // WorkspaceSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(projectListFL);
            Name = "WorkspaceSettingsForm";
            Text = "WorkspaceSettingsForm";
            Load += WorkspaceSettingsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel projectListFL;
    }
}
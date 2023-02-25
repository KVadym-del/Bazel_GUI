namespace Bazel_GUI {
    partial class CreateProjForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjForm));
            CreateProjectB = new Button();
            ProjectNameT = new TextBox();
            LanguageListB = new ComboBox();
            SuspendLayout();
            // 
            // CreateProjectB
            // 
            CreateProjectB.Location = new Point(12, 61);
            CreateProjectB.Name = "CreateProjectB";
            CreateProjectB.Size = new Size(436, 23);
            CreateProjectB.TabIndex = 3;
            CreateProjectB.Text = "Create Project";
            CreateProjectB.UseVisualStyleBackColor = true;
            CreateProjectB.Click += CreateProjectB_Click;
            // 
            // ProjectNameT
            // 
            ProjectNameT.Location = new Point(12, 12);
            ProjectNameT.Name = "ProjectNameT";
            ProjectNameT.Size = new Size(309, 23);
            ProjectNameT.TabIndex = 4;
            ProjectNameT.Text = "MyProjectName";
            // 
            // LanguageListB
            // 
            LanguageListB.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageListB.FormattingEnabled = true;
            LanguageListB.Location = new Point(327, 12);
            LanguageListB.Name = "LanguageListB";
            LanguageListB.Size = new Size(121, 23);
            LanguageListB.TabIndex = 5;
            // 
            // CreateProjForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 96);
            Controls.Add(LanguageListB);
            Controls.Add(ProjectNameT);
            Controls.Add(CreateProjectB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(476, 135);
            MinimumSize = new Size(476, 135);
            Name = "CreateProjForm";
            Text = "CreateProjForm";
            Load += CreateProjForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CreateProjectB;
        private TextBox ProjectNameT;
        private ComboBox LanguageListB;
    }
}
namespace Bazel_GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            CreateProjectTB = new ToolStripMenuItem();
            OpenProjectTB = new ToolStripMenuItem();
            ProjectLocationT = new TextBox();
            ListOfProjectsFL = new FlowLayoutPanel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { CreateProjectTB, OpenProjectTB });
            toolStripDropDownButton1.Image = Properties.Resources.tool_wrench_icon_158120;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // CreateProjectTB
            // 
            CreateProjectTB.Name = "CreateProjectTB";
            CreateProjectTB.Size = new Size(180, 22);
            CreateProjectTB.Text = "Create Project";
            CreateProjectTB.Click += CreateProjectTB_Click;
            // 
            // OpenProjectTB
            // 
            OpenProjectTB.Name = "OpenProjectTB";
            OpenProjectTB.Size = new Size(180, 22);
            OpenProjectTB.Text = "Open Project";
            OpenProjectTB.Click += OpenProjectTB_Click;
            // 
            // ProjectLocationT
            // 
            ProjectLocationT.Location = new Point(12, 28);
            ProjectLocationT.Name = "ProjectLocationT";
            ProjectLocationT.ReadOnly = true;
            ProjectLocationT.Size = new Size(776, 23);
            ProjectLocationT.TabIndex = 1;
            ProjectLocationT.Text = "NULL\\";
            // 
            // ListOfProjectsFL
            // 
            ListOfProjectsFL.AutoScroll = true;
            ListOfProjectsFL.Location = new Point(12, 57);
            ListOfProjectsFL.Name = "ListOfProjectsFL";
            ListOfProjectsFL.Size = new Size(776, 381);
            ListOfProjectsFL.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListOfProjectsFL);
            Controls.Add(ProjectLocationT);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "Main";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem CreateProjectTB;
        private TextBox ProjectLocationT;
        private FlowLayoutPanel ListOfProjectsFL;
        private ToolStripMenuItem OpenProjectTB;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazel_GUI
{
    public partial class BUILDbazel : Form
    {
        public string BUILDbazelName = String.Empty;
        public string BUILDbazelPath = String.Empty;

        public string BUILDbazelTempName = "BUILDbazel";

        public string contents = String.Empty;

        public BUILDbazel()
        {
            InitializeComponent();
            this.Text = BUILDbazelTempName; /// BUILDbazelName
        }

        private void BUILDbazel_Load(object sender, EventArgs e)
        {
            contents = File.ReadAllText(BUILDbazelPath);
            BUILDtextT.Text = contents;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            File.AppendAllText(BUILDbazelPath, contents + BUILDbazelPath);
            this.Text = BUILDbazelTempName;
        }

        private void BUILDtextT_TextChanged(object sender, EventArgs e)
        {
            this.Text = BUILDbazelTempName + "*";
        }
    }
}

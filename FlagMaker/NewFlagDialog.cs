using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public partial class NewFlagDialog : Form
    {

        public Flag Flag { get; private set; }

        public NewFlagDialog()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                this.Flag = new Flag(txtName.Text);
                this.Flag.Changed = true;
                this.Flag.Background = btnColor.BackColor;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            ColorDialog dlg = new ColorDialog();
            dlg.Color = btnColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = dlg.Color;
            }

        }
    }
}

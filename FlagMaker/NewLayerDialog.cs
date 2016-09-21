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
    public partial class NewLayerDialog : Form
    {

        public Layer Selected { get; set; }

        public NewLayerDialog()
        {
            InitializeComponent();
        }

        private void NewLayerDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnHorizontalStripe_Click(object sender, EventArgs e)
        {
            this.Selected = new LayerHorizontalStripe();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnVerticalStripes_Click(object sender, EventArgs e)
        {
            this.Selected = new LayerVerticalStripe();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnDiagonalStripe_Click(object sender, EventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.Selected = new LayerRectangle();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnOval_Click(object sender, EventArgs e)
        {
            this.Selected = new LayerOval();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {

        }

    }
}

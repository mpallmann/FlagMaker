using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public partial class StripeEditor : UserControl, IEditor
    {

        public event EventHandler SettingsChanged;

#region "Properties"

        public LayerStripe Layer { get; set; }

#endregion

        public StripeEditor(LayerStripe layer)
        {
            this.Layer = layer;
            InitializeComponent();
        }

        private void StripeEditor_Load(object sender, EventArgs e)
        {
            numStripes.Value = this.Layer.NumberOfStripes;
            btnColor.BackColor = this.Layer.Color;
            chkStartStripe.Checked = this.Layer.StartOnStripe;
            chkEndStripe.Checked = this.Layer.EndOnStripe;
            slStripeSpacing.Value = (int) (this.Layer.StripeSize * 1000);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = btnColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = dlg.Color;
                this.Layer.Color = btnColor.BackColor;
            }
            if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
        }

        private void numStripes_ValueChanged(object sender, EventArgs e)
        {
            this.Layer.NumberOfStripes = (Int32)numStripes.Value;
            if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
        }

        private void chkStartStripe_CheckedChanged(object sender, EventArgs e)
        {
            this.Layer.StartOnStripe = chkStartStripe.Checked;
            if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
        }

        private void chkEndStripe_CheckedChanged(object sender, EventArgs e)
        {
            this.Layer.EndOnStripe = chkEndStripe.Checked;
            if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
        }

        private void txtStripePercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpacePercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void slStripeSpacing_Scroll(object sender, EventArgs e)
        {
            setPercent();
        }

        private void setPercent()
        {
            double stripe = slStripeSpacing.Value / 1000d;
            double space = (1000d - slStripeSpacing.Value) / 1000d;

            txtStripePercent.Text = ((Int32)(stripe * 100d)).ToString();
            txtSpacePercent.Text = ((Int32)(space * 100d)).ToString();

            this.Layer.StripeSize = (float)stripe;
            this.Layer.SpaceSize = (float)space;

            if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
        }

    }
}

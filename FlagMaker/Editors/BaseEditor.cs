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
    public partial class BaseEditor : UserControl, IEditor
    {

        public event EventHandler SettingsChanged;

        private Flag _flag;

        public BaseEditor(Flag flag)
        {
            _flag = flag;
            InitializeComponent();
        }

        private void BaseEditor_Load(object sender, EventArgs e)
        {
            btnBackground.BackColor = _flag.Background;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = btnBackground.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _flag.Background = dlg.Color;
                if (this.SettingsChanged != null) this.SettingsChanged(sender, e);
            }
        }

    }
}

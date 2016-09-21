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
    public partial class ShapeEditor : UserControl, IEditor
    {

        public event EventHandler SettingsChanged;

        private LayerShape _layer;
        private bool _updating = false;
        private bool _update_list = false;

        public bool ChangePointAllowed {
            get { return btnAddPoint.Visible; }
            set {
                btnAddPoint.Visible = value;
                btnRemovePoint.Visible = value;
                sep1.Visible = (btnAddPoint.Visible && mnuOrder.Visible);
            } 
        }
        public bool OrderPointAllowed {
            get { return mnuOrder.Visible; }
            set { 
                mnuOrder.Visible = value;
                sep1.Visible = (btnAddPoint.Visible && mnuOrder.Visible);
            } 
        }

        public ShapeEditor(LayerShape layer)
        {
            _layer = layer;
            InitializeComponent();
        }

        private void ShapeEditor_Load(object sender, EventArgs e)
        {
            _updating = true;
            sldX.Enabled = false;
            sldY.Enabled = false;
            btnColor.BackColor = _layer.Color;
            displayPoints();
            this.ChangePointAllowed = false;
            this.OrderPointAllowed = false;
            _updating = false;
        }

        private void displayPoints()
        {
            lstPoints.BeginUpdate();
            lstPoints.Items.Clear();
            foreach (PointF pnt in _layer.Points)
            {
                lstPoints.Items.Add(pnt.X + ", " + pnt.Y);
            }
            lstPoints.EndUpdate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = btnColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = dlg.Color;
                _layer.Color = btnColor.BackColor;
                if (this.SettingsChanged != null) this.SettingsChanged(sender, e);
            }
        }

        private void lstPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_updating)
            {
                _updating = true;
                if (lstPoints.SelectedIndex > -1)
                {
                    int index = lstPoints.SelectedIndex;
                    sldX.Value = (int)(_layer.Points[index].X * 1000);
                    sldY.Value = (int)(_layer.Points[index].Y * 1000);
                    sldX.Enabled = true;
                    sldY.Enabled = true;
                }
                else
                {
                    sldX.Enabled = false;
                    sldY.Enabled = false;
                }
                _updating = false;
            }
        }

        private void updatePoint(float x, float y)
        {
            if (lstPoints.SelectedIndex > -1)
            {
                int index = lstPoints.SelectedIndex;
                _layer.Points[index] = new PointF(x, y);
                _update_list = true;
                if (this.SettingsChanged != null) this.SettingsChanged(this, new EventArgs());
            }
        }

        private void sldX_ValueChanged(object sender, EventArgs e)
        {
            if (!_updating)
            {
                updatePoint((float)(sldX.Value / 1000d), (float)(sldY.Value / 1000d));
            }
        }

        private void sldY_ValueChanged(object sender, EventArgs e)
        {
            if (!_updating)
            {
                updatePoint((float)(sldX.Value / 1000d), (float)(sldY.Value / 1000d));
            }
        }

        private void sldX_MouseUp(object sender, MouseEventArgs e)
        {
            updateList();
        }

        private void sldY_MouseUp(object sender, MouseEventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            if (_update_list)
            {
                _updating = true ;
                int index = lstPoints.SelectedIndex;
                displayPoints();
                lstPoints.SelectedIndex = index;
                _updating = false ;
            }
            _update_list = false;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnRemovePoint_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {

        }

    }
}

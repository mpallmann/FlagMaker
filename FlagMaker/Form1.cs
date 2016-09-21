using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public partial class Form1 : Form
    {
        private FlagViewer pnlFlag = new FlagViewer();
        private List<Flag> _flags = new List<Flag>();

        public Form1()
        {
            InitializeComponent();
            splitContainer1.Panel2.Controls.Add(pnlFlag);
            pnlFlag.Dock = DockStyle.Fill;
            pnlFlag.BringToFront();
        }

        private void checkDirectories()
        {
            if (!Directory.Exists(Application.StartupPath + "\\flags\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\flags\\");
            }
            else
            {
                String[] files = Directory.GetFiles(Application.StartupPath + "\\flags\\");
                foreach (String file in files)
                {
                    if (file.EndsWith(".flg"))
                    {
                        try
                        {
                            Flag flag = new Flag();
                            flag.parse(File.ReadAllText(file));
                            _flags.Add(flag);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            if (lstFlags.SelectedIndex > -1)
            {
                int index = lstFlags.SelectedIndex;
                NewLayerDialog dlg = new NewLayerDialog();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _flags[index].Layers.Add(dlg.Selected);
                    displayLayers(_flags[index]);
                    lstLayers.SelectedIndex = lstLayers.Items.Count - 1;
                    pnlFlag.Invalidate();
                    _flags[index].Changed = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkDirectories();
            //setupSampleFlags();
            displayFlags();

        }

        private void setupSampleFlags()
        {

            Flag f1 = new Flag("2 Horz Stripes");
            f1.Background = Color.White;
            LayerHorizontalStripe f1l1 = new LayerHorizontalStripe();
            f1l1.Color = Color.Red;
            f1l1.NumberOfStripes = 2;
            f1.Layers.Add(f1l1);
            _flags.Add(f1);

            Flag f2 = new Flag("4 Vert Stripes");
            f2.Background = Color.Black;
            LayerVerticalStripe f2l1 = new LayerVerticalStripe();
            f2l1.Color = Color.LightBlue;
            f2l1.NumberOfStripes = 4;
            f2l1.StartOnStripe = false;
            f2l1.EndOnStripe = false;
            f2.Layers.Add(f2l1);
            _flags.Add(f2);

            Flag f3 = new Flag("Rect");
            f3.Background = Color.White;
            LayerRectangle f3l1 = new LayerRectangle(new RectangleF(0f, 0f, 0.5f, 0.5f));
            f3l1.Color = Color.Blue;
            f3.Layers.Add(f3l1);
            _flags.Add(f3);

            Flag f4 = new Flag("American");
            f4.Background = Color.White;
            LayerHorizontalStripe f4l1 = new LayerHorizontalStripe();
            f4l1.NumberOfStripes = 7;
            f4l1.Color = Color.Red;
            f4.Layers.Add(f4l1);
            LayerRectangle f4l2 = new LayerRectangle(new RectangleF(0f, 0f, 0.5f, 0.539f));
            f4l2.Color = Color.Blue;
            f4.Layers.Add(f4l2);
            _flags.Add(f4);

        }

        private void displayFlags()
        {
            lstFlags.BeginUpdate();
            lstFlags.Items.Clear();
            foreach (Flag fl in _flags)
            {
                lstFlags.Items.Add(fl.Name);
            }
            lstFlags.EndUpdate();
        }

        private void displayLayers(Flag flag)
        {
            lstLayers.BeginUpdate() ;
            lstLayers.Items.Clear();
            lstLayers.Items.Add("Background");
            foreach (Layer layer in flag.Layers)
            {
                lstLayers.Items.Add(layer.Name);
            }
            lstLayers.EndUpdate();
        }

        private void lstFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFlags.SelectedIndex > -1) 
            {
                pnlFlag.Flag = _flags[lstFlags.SelectedIndex];
                displayLayers(pnlFlag.Flag);
            }
            else
            {
                pnlFlag.Flag = null;
            }
            pnlFlag.Invalidate();
            pnlEditor.Controls.Clear();
            pnlEditor.Visible = false;
        }

        private void lstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEditor.Controls.Clear();
                    
            if (lstLayers.SelectedIndex > -1)
            {
                Flag flag = pnlFlag.Flag;
                if (flag != null)
                {
                    IEditor ed = null;
                    if (lstLayers.SelectedIndex == 0)
                    {
                        ed = new BaseEditor(flag);
                    }
                    else
                    {
                        Layer layer = flag.Layers[lstLayers.SelectedIndex - 1];
                        ed = layer.showSettings();
                    }
                    if (ed != null)
                    {
                        ed.SettingsChanged += ed_SettingsChanged;
                        pnlEditor.Controls.Add((Control)ed);
                        ((Control)ed).Dock = DockStyle.Fill;
                    }
                }
            }

            pnlEditor.Visible = (pnlEditor.Controls.Count > 0);
        }

        void ed_SettingsChanged(object sender, EventArgs e)
        {
            pnlFlag.Invalidate();
            pnlFlag.Flag.Changed = true;
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            if (lstFlags.SelectedIndex > -1) 
            {
                int index = lstFlags.SelectedIndex ;
                if (lstLayers.SelectedIndex > 0)
                {
                    _flags[index].Layers.RemoveAt(lstLayers.SelectedIndex - 1);
                    displayLayers(_flags[index]);
                    pnlFlag.Invalidate();
                    _flags[index].Changed = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Flag flag in _flags)
            {
                if (flag.Changed)
                {
                    string filename = Application.StartupPath + "\\Flags\\" + flag.Name + ".flg";
                    if (File.Exists(filename)) File.Delete(filename);

                    File.WriteAllText(filename, flag.ToSaveText());
                }
            }
        }

        private bool checkFilename(String filename)
        {

            foreach (Flag flag in _flags)
            {
                if (flag.Name == filename)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnNewFlag_Click(object sender, EventArgs e)
        {
            NewFlagDialog dlg = new NewFlagDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if (checkFilename(dlg.Flag.Name))
                {
                    _flags.Add(dlg.Flag);
                    displayFlags();
                }
                else
                {
                    MessageBox.Show("This flag already exists");
                }
            }
        }

        private void btnDeleteFlag_Click(object sender, EventArgs e)
        {
            if (lstFlags.SelectedIndex > -1) 
            {
                int index = lstFlags.SelectedIndex ;
                String filename = Application.StartupPath + "\\Flags\\" + _flags[index].Name + ".flg" ;
                if (File.Exists(filename))
                {
                    if (MessageBox.Show("Delete Flag?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(filename);
                    }
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public abstract class Layer
    {
        public String Name { get; set; }
        public Color Color { get; set; }
        public Dictionary<String, String> Attributes { get; set; }

        public abstract IEditor showSettings();
        public abstract void draw(Graphics g, SizeF scale, PointF start);
        public abstract String ToSaveText();

        public Layer()
        {
            this.Attributes = new Dictionary<String, String>();
        }

        public Layer(String name)
        {
            this.Name = name;
            this.Attributes = new Dictionary<String, String>();
        }

    }
}

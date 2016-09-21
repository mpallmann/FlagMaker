using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagMaker
{
    public abstract class LayerShape : Layer
    {

        public List<PointF> Points { get; set; }

        public LayerShape()
        {
            this.Points = new List<PointF>();   
            this.Color = Color.White;
        }

        public override IEditor showSettings()
        {
            return new ShapeEditor(this); 
        }

        public override string ToSaveText()
        {
            StringBuilder ret = new StringBuilder();

            ret.Append(this.Name);
            ret.Append(":[" );
            foreach (PointF pnt in this.Points) 
            {
                ret.Append(pnt.X + "," + pnt.Y + ";") ;
            }
            ret.Append("]");
            ret.Append(":#" + this.Color.R.ToString("X").PadLeft(2, '0'));
            ret.Append(this.Color.G.ToString("X").PadLeft(2, '0'));
            ret.Append(this.Color.B.ToString("X").PadLeft(2, '0'));
            //ret.Append("\n");
            return ret.ToString();
        }

        public override void draw(System.Drawing.Graphics g, System.Drawing.SizeF scale, System.Drawing.PointF start)
        {
            if (Points.Count >= 2)
            {

                GraphicsPath gp = new GraphicsPath();
                PointF last_pnt = new PointF(0, 0);
                bool first = true;
                foreach (PointF pnt in this.Points)
                {
                    if (first) {
                        first = false;
                    }
                    else
                    {
                        gp.AddLine(last_pnt, pnt);
                    }
                    last_pnt = pnt ;
                }
                //close shape
                gp.AddLine(this.Points[0], last_pnt);

                g.FillPath(new SolidBrush(this.Color), gp);

            }
        }

    }
}

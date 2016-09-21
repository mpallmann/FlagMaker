using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public class LayerRectangle : LayerShape
    {

        public LayerRectangle()
        {
            this.Name = "Rectangle";
            this.Points.Clear();
            this.Points.Add(new PointF(0f, 0f));
            this.Points.Add(new PointF(1f, 1f));
        }

        public LayerRectangle(RectangleF r)
        {
            this.Name = "Rectangle";
            this.Points.Clear();
            this.Points.Add(new PointF(r.Left, r.Top));
            this.Points.Add(new PointF(r.Right, r.Bottom));
        }

        public override IEditor showSettings()
        {
            IEditor ret = base.showSettings();
            ((ShapeEditor)ret).ChangePointAllowed = true;
            ((ShapeEditor)ret).OrderPointAllowed = true;

            return ret;
        }

        public override void draw(System.Drawing.Graphics g, System.Drawing.SizeF scale, System.Drawing.PointF start)
        {
            if (Points.Count >= 2)
            {
                RectangleF r = new RectangleF(this.Points[0].X * scale.Width, this.Points[0].Y * scale.Height,
                                             this.Points[1].X * scale.Width, this.Points[1].Y * scale.Height);

                g.FillRectangle(new SolidBrush(this.Color), r);
            }
        }

    }
}

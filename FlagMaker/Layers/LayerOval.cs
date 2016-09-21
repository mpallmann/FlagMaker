using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagMaker
{
    public class LayerOval : LayerShape
    {

        public LayerOval()
        {
            this.Name = "Oval Layer";
            this.Points.Clear();
            this.Points.Add(new PointF(0f, 0f));
            this.Points.Add(new PointF(1f, 1f));
        }

        public override void draw(System.Drawing.Graphics g, System.Drawing.SizeF scale, System.Drawing.PointF start)
        {
            if (Points.Count >= 2)
            {
                RectangleF r = new RectangleF(this.Points[0].X * scale.Width, this.Points[0].Y * scale.Height,
                                             this.Points[1].X * scale.Width, this.Points[1].Y * scale.Height);

                g.FillEllipse(new SolidBrush(this.Color), r);
            }
        }

    }
}

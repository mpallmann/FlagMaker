using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public class LayerHorizontalStripe : LayerStripe
    {


        public LayerHorizontalStripe()
        {
            this.Name = "Horizontal Stripe";
        }

        public override void draw(System.Drawing.Graphics g, SizeF scale, PointF start)
        {

            int stripe_count = this.NumberOfStripes ;
            int space_count = this.NumberOfStripes - 1;
            if (!this.StartOnStripe) space_count++ ;
            if (!this.EndOnStripe) space_count++ ;

            double total_ratio = (this.NumberOfStripes * this.StripeSize) + (space_count * this.SpaceSize) ;

            bool stripe_on = this.StartOnStripe;

            double line_top = 0.0d;
            for (int i = 0; i < (stripe_count + space_count); i++)
            {
                double line_height = 0.0d;
                if (stripe_on)
                {
                    line_height = (this.StripeSize / total_ratio) * scale.Height;
                    g.FillRectangle(new SolidBrush(this.Color), 0.0f, (float)line_top, (float)scale.Width, (float)line_height);
                }
                else
                {
                    line_height = (this.SpaceSize / total_ratio) * scale.Height;
                }
                stripe_on = !stripe_on;
                line_top += line_height;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public class LayerVerticalStripe : LayerStripe
    {

        public LayerVerticalStripe()
        {
            this.Name = "Vertical Stripe";
        }

        public override void draw(System.Drawing.Graphics g, SizeF scale, PointF start)
        {

            int stripe_count = this.NumberOfStripes;
            int space_count = this.NumberOfStripes - 1;
            if (!this.StartOnStripe) space_count++;
            if (!this.EndOnStripe) space_count++;

            double total_ratio = (this.NumberOfStripes * this.StripeSize) + (space_count * this.SpaceSize);

            bool stripe_on = this.StartOnStripe;

            double line_left = 0.0d;
            for (int i = 0; i < (stripe_count + space_count); i++)
            {
                double line_width = 0.0d;
                if (stripe_on)
                {
                    line_width = (this.StripeSize / total_ratio) * scale.Width;
                    g.FillRectangle(new SolidBrush(this.Color), (float)line_left, 0.0f, (float)line_width, (float)scale.Height);
                }
                else
                {
                    line_width = (this.SpaceSize / total_ratio) * scale.Width;
                }
                stripe_on = !stripe_on;
                line_left += line_width;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlagMaker
{
    public abstract class LayerStripe : Layer
    {
        public Int32 NumberOfStripes { get; set; }
        public bool StartOnStripe { get; set; }
        public bool EndOnStripe { get; set; }
        public float StripeSize { get; set; }
        public float SpaceSize { get; set; }

        public LayerStripe()
        {
            this.Color = Color.White;
            this.NumberOfStripes = 1;
            this.StartOnStripe = true;
            this.EndOnStripe = true;
            this.StripeSize = 0.5f;
            this.SpaceSize = 0.5f;
        }

        //public abstract draw(Graphics g, SizeF scale, PointF start) ;

        public override IEditor showSettings()
        {
            StripeEditor ret = new StripeEditor(this);

            return ret;
        }

        public override string ToSaveText()
        {
            StringBuilder ret = new StringBuilder();

            ret.Append(this.Name);
            ret.Append(":" + this.NumberOfStripes);
            ret.Append(":" + this.StripeSize);
            ret.Append(":" + this.SpaceSize);
            if (this.StartOnStripe)
                ret.Append(":1");
            else
                ret.Append(":0");
            if (this.EndOnStripe)
                ret.Append(":1");
            else
                ret.Append(":0");
            ret.Append(":#" + this.Color.R.ToString("X").PadLeft(2, '0'));
            ret.Append(this.Color.G.ToString("X").PadLeft(2, '0'));
            ret.Append(this.Color.B.ToString("X").PadLeft(2, '0'));
            //ret.Append("\n");

            return ret.ToString();
        }

    }
}

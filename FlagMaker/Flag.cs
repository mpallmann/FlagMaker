using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagMaker
{
    public class Flag
    {

        public String Name { get; set; }
        public Color Background { get; set; }
        public SizeF Aspect { get; set; }
        public List<Layer> Layers { get; set; }
        public bool Changed { get; set; }

        public Flag()
        {
            this.Background = Color.White;
            this.Aspect = new SizeF(1f, 0.6f);
            this.Layers = new List<Layer>();
            this.Changed = false;
        }

        public Flag(String name)
        {
            this.Name = name;
            this.Background = Color.White;
            this.Aspect = new SizeF(1f, 0.6f);
            this.Layers = new List<Layer>();
            this.Changed = false;
        }

        private RectangleF buildRect(string text)
        {
            String temp = text.Trim();
            if (temp.StartsWith("[")) temp = temp.Substring(1);
            if (temp.EndsWith("]")) temp = temp.Substring(0, temp.Length - 1);
            String[] items = temp.Split(',');
            if (items.Count() < 4) throw new Exception("Bad Format for Rectangle: " + text);

            float x1, y1, x2, y2;
            if (float.TryParse(items[0], out x1) == false) throw new Exception("Error parsing number: " + items[0]);
            if (float.TryParse(items[1], out y1) == false) throw new Exception("Error parsing number: " + items[0]);
            if (float.TryParse(items[2], out x2) == false) throw new Exception("Error parsing number: " + items[0]);
            if (float.TryParse(items[3], out y2) == false) throw new Exception("Error parsing number: " + items[0]);

            return new RectangleF(x1, y1, x2, y2);
        }

        private Color colorFromHex(String hex)
        {
            String temp = hex.Trim();
            if (temp.StartsWith("#")) temp = temp.Substring(1) ;
            if (temp.Length < 6) throw new Exception("Bad Color Format: " + hex) ;
            Byte R = Byte.Parse(temp.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            Byte G = Byte.Parse(temp.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            Byte B = Byte.Parse(temp.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);

            return Color.FromArgb(R, G, B);
        }

        public List<PointF> buildPointArray(String text)
        {
            List<PointF> ret = new List<PointF>();

            String temp = text;
            if (temp.StartsWith("[")) temp = temp.Substring(1);
            if (temp.EndsWith("]")) temp = temp.Substring(0, temp.Length - 1);

            String[] coords;
            if (temp.Contains(";"))
            {
                coords = temp.Split(';');
            }
            else
            {
                coords = new String[1];
                coords[0] = temp;
            }

            foreach (String c in coords)
            {
                if (c.Contains(","))
                {
                    String[] items = c.Split(',');
                    float x, y;
                    if (float.TryParse(items[0], out x) && float.TryParse(items[1], out y))
                    {
                        PointF p = new PointF(x, y);
                        ret.Add(p);
                    }
                }
            }

            return ret;
        }

        public void parse(string text)
        {
            String[] lines = text.Split('\n');
            foreach (String line in lines)
            {
                if (line.Contains(":"))
                {
                    String[] items = line.Split(':');
                    if (items[0] == "Rectangle")
                    {
                        LayerRectangle layer = new LayerRectangle();
                        layer.Points = buildPointArray(items[1]);
                        layer.Color = colorFromHex(items[2]);
                        this.Layers.Add(layer);
                    }
                    else if (items[0] == "Oval")
                    {
                        LayerOval layer = new LayerOval();
                        layer.Points = buildPointArray(items[1]);
                        layer.Color = colorFromHex(items[2]);
                        this.Layers.Add(layer);
                    }
                    else if (items[0] == "Horizontal Stripe") {
                        LayerHorizontalStripe layer = new LayerHorizontalStripe();
                        layer.NumberOfStripes = Int32.Parse(items[1]);
                        layer.StripeSize = float.Parse(items[2]);
                        layer.SpaceSize = float.Parse(items[3]);
                        layer.StartOnStripe = (items[4] == "1");
                        layer.EndOnStripe = (items[5] == "1");
                        layer.Color = colorFromHex(items[6]);
                        this.Layers.Add(layer);
                    }
                    else if (items[0] == "Vertical Stripe") {
                        LayerVerticalStripe layer = new LayerVerticalStripe();
                        layer.NumberOfStripes = Int32.Parse(items[1]);
                        layer.StripeSize = float.Parse(items[2]);
                        layer.SpaceSize = float.Parse(items[3]);
                        layer.StartOnStripe = (items[4] == "0");
                        layer.EndOnStripe = (items[5] == "0");
                        layer.Color = colorFromHex(items[6]);
                        this.Layers.Add(layer);
                    }
                    else
                    {
                        this.Name = items[0];
                        this.Background = colorFromHex(items[1].Trim());
                    }
                }
            }
        }

        public void draw(Graphics g, float scale, PointF start)
        {
            g.FillRectangle(new SolidBrush(this.Background), start.X, start.Y, this.Aspect.Width * scale, this.Aspect.Height*scale);
            SizeF fscale = new SizeF(this.Aspect.Width*scale, this.Aspect.Height*scale) ;
            foreach (Layer layer in this.Layers)
            {
                layer.draw(g, fscale, start);
            }
        }

        public String ToSaveText()
        {
            StringBuilder ret = new StringBuilder();


            ret.Append(this.Name);
            ret.Append(":#" + this.Background.R.ToString("X").PadLeft(2, '0'));
            ret.Append(this.Background.G.ToString("X").PadLeft(2, '0'));
            ret.AppendLine(this.Background.B.ToString("X").PadLeft(2, '0'));
            foreach (Layer layer in this.Layers)
            {
                ret.AppendLine(layer.ToSaveText());
            }

            return ret.ToString();
        }

    }

}

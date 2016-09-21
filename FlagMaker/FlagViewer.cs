using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker
{
    public class FlagViewer : Panel
    {

        public Flag Flag { get; set; }

        public FlagViewer()
        {
            this.DoubleBuffered = true;
        }

        public FlagViewer(Flag flag)
        {
            this.Flag = flag;
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.Flag != null) {
                float scale = this.ClientSize.Width ;
                if (this.Flag.Aspect.Height > this.Flag.Aspect.Width) {
                    scale = this.ClientSize.Height;
                }
                this.Flag.draw(e.Graphics, scale, new System.Drawing.PointF(0, 0));
            }
        }

    }
}

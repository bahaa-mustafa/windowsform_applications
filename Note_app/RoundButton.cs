using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_app
{
    class RoundButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 1, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(p);
            base.OnPaint(pevent);

        }
    }
}

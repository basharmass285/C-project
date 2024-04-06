using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endproject_
{
    internal class Uilist
    {
        public static int GetTextheight(Label lbl)
        {
            using(Graphics g = lbl.CreateGraphics())
            {

                SizeF size = g.MeasureString(lbl.Text, lbl.Font,495);
                return(int)Math.Ceiling(size.Height);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramDesignPattern.Abstractions;
using System.Drawing;

namespace ProgramDesignPattern.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color boxColor, Color ribbonColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbonColor);
        }

        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(BoxColor, 0, 0, Width, Height);
            graphics.FillRectangle(RibbonColor, 0, Height - ((Height / 5) * 3), Width, Height / 5);
            graphics.FillRectangle(RibbonColor, Width - ((Width / 5) * 3), 0, Width / 5, Height);
        }
    }
}

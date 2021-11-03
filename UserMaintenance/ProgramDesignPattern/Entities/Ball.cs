using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProgramDesignPattern.Abstractions;

namespace ProgramDesignPattern.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }
        Random rnd = new Random();

        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
            Click += Ball_Click;
        }

        private void Ball_Click(object sender, EventArgs e)
        {
            BallColor = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            Invalidate();
        }

        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillEllipse(BallColor, 0, 0, Width, Height);
        }
    }
}

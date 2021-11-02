using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramDesignPattern.Entities;

namespace ProgramDesignPattern
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }



        #region Properties
        private BallFactory _factory;

        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        #endregion

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Ball b = Factory.CreateNew();
            b.Top = (mainPanel.Height - b.Height) / 2;
            b.Left = -b.Width;
            _balls.Add(b);
            mainPanel.Controls.Add(b);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > maxPosition) maxPosition = ball.Left;
            }

            if(maxPosition > 1000)
            {
                Ball oldestBall = _balls[0];
                mainPanel.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);
            }
        }
    }
}

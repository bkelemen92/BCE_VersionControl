using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramDesignPattern.Abstractions;
using ProgramDesignPattern.Entities;

namespace ProgramDesignPattern
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }



        #region Properties
        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        #endregion

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Toy b = Factory.CreateNew();
            b.Top = (mainPanel.Height - b.Height) / 2;
            b.Left = -b.Width;
            _toys.Add(b);
            mainPanel.Controls.Add(b);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition) maxPosition = toy.Left;
            }

            if(maxPosition > 1000)
            {
                Toy oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }
    }
}

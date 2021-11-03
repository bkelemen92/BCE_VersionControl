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
        private Toy _nextToy;
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
            set { _factory = value; DisplayNext(); }
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


        private void DisplayNext()
        {
            if (_nextToy != null) Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = lbl_NextItem.Top + lbl_NextItem.Height + 20;
            _nextToy.Left = lbl_NextItem.Left;
            Controls.Add(_nextToy);
        }



        private void btn_BallSelector_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory() { BallColor = btn_BallColor.BackColor };
        }

        private void btn_CarSelector_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }
        private void btn_PresentSelector_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory() { BoxColor = btn_BoxColor.BackColor, RibbonColor = btn_RibbonColor.BackColor };
        }

        private void btn_ColorSelector_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorPicker = new ColorDialog() { Color = ((Button)sender).BackColor })
            {
                if (colorPicker.ShowDialog() != DialogResult.OK) return;
                ((Button)sender).BackColor = colorPicker.Color;
            }
        }

        
    }
}

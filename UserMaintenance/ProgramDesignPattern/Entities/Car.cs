﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramDesignPattern.Abstractions;

namespace ProgramDesignPattern.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics graphics)
        {
            graphics.DrawImage(Image.FromFile(""), new Rectangle(0, 0, Width, Height));
        }
    }
}

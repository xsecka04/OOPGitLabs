﻿using System;
namespace OOPGitLabs.Pages.Lab7_Classes
{
    public class Elipsa : Objekt2D
    {

        private double width;
        private double height;

        public Elipsa(double width, double height)
        {
            this.width = width;
            this.height = height;

        }


        public override String ToString()
        {
            return "Ellipse with axes " + width + " and " + height;

        }

        public override double Plocha()
        {
            return Math.PI * width * height;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Pelican : Bird
    {
        private double beakLong;

        public double BeakLong
        {
            get { return beakLong; }
            set { beakLong = value; }
        }

        public Pelican(string name, double weight, int age, int wingSpan) :base(name, weight, age, wingSpan)
        {
            BeakLong = beakLong;
        }
    }
}

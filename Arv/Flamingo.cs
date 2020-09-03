using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Flamingo : Bird
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Flamingo(string name, double weight, int age, int wingSpan) :base(name, weight, age, wingSpan)
        {
            Color = color;
        }
    }
}

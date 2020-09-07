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

        public Flamingo(string name, double weight, int age, int wingSpan, string color) :base(name, weight, age, wingSpan)
        {
            Color = color;
        }

        //Tips: Kan även överskugga (override) Bird:s DoSound method.
        public override string DoSound()
        {
            return "Flaming sound";
        }

        public override string Stats()
        {
            return $"{base.Stats()} Color: {Color}";
        }
    }
}

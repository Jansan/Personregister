using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Swan​ : Bird
    {
        private bool flying;

        public bool Flying
        {
            get { return flying; }
            set { flying = value; }
        }

        public Swan​(string name, double weight, int age, int wingSpan) :base(name, weight, age, wingSpan)
        {
            Flying = flying;
        }
    }
}

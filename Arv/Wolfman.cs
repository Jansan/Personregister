using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, double taillong) :base(name, weight, age, taillong)
        {

        }

        public void Talk()
        {
            Console.WriteLine("Hello from wolfman");
        }
        
    }
}

namespace Arv
{
    class Wolf : Animal
    {
        private double taillong;

        public double TailLong
        {
            get { return taillong; }
            set { taillong = value; }
        }

        public Wolf(string name, double weight, int age) :base(name, weight, age)
        {
            TailLong = taillong;
        }

        public override string DoSound()
        {
            return "Wolf Sound";
        }
    }
}
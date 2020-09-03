namespace Arv
{
    class Horse : Animal
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Horse(string name, double weight, int age, int speed) :base(name, weight, age)
        {
            Speed = speed;
        }

        public override string DoSound()
        {
            return "Horse sound";
        }
    }
}
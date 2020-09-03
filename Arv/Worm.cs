namespace Arv
{
    class Worm : Animal
    {
        private bool poisonous;

        public bool Poisonous
        {
            get { return poisonous; }
            set { poisonous = value; }
        }

        public Worm(string name, double weight, int age, bool poisonous) :base(name, weight, age)
        {
            Poisonous = poisonous;
        }
       public override string DoSound()
        {
            return "Worm Sound";
        }
    }
}
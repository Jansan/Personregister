namespace Arv
{
    class Bird : Animal
    {
        private int wingSpan;

        public int WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        public Bird(string name, double weight, int age, int wingSpan) :base(name, weight, age)
        {

        }
        public override string DoSound()
        {
            return "Bird Sound";
        }
    }
}
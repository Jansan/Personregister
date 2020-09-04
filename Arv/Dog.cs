namespace Arv
{
    class Dog : Animal
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public Dog(string name, double weight, int age, double height) :base(name, weight, age)
        {
            Height = height;
        }
        public override string DoSound()
        {
            return "Dog Sound";
        }
    }
}
namespace Arv
{
    abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract string DoSound();
       

    }
    class Horse: Animal
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
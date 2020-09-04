namespace Arv
{
    class Hedgehog​ : Animal
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public Hedgehog​(string name, double weight, int age, string color) :base(name, weight, age)
        {
            Color = color;
        }

        public override string DoSound()
        {
            return "Hedgehog sound";
        }
    }
}
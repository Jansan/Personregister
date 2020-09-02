using System;
using System.Collections.Generic;
using System.Text;

namespace Personregister
{
    class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private float height;

        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Personregister
{
    // Person class
    class Person
    {
        // private age property
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age can only be greater than 0");
                age = value;
            }
        }

        // private firstname property
        private string firstName;
        
        public string FirstName
        {
            get 
            {
                return firstName; 
            }
            set 
            {
                //validate the input
                if (string.IsNullOrEmpty(value))
                
                    throw new ArgumentNullException("FirstName cannot be null");

                if (value.Length < 2 && value.Length > 10)

                    throw new ArgumentOutOfRangeException("FirstName cannot be minst 2 and longer than 10 ");
                
                firstName = value;
            }
        }
        // private lastname property
        private string lastName;
       
        public string LastName
        {
            get
            { 
                return lastName; 
            }
            set
            {    //validate the input
                if (string.IsNullOrEmpty(value))
                
                    throw new ArgumentNullException("Lastname cannot be null");
                if (value.Length < 3 && value.Length > 15)
                    throw new ArgumentOutOfRangeException("LastName cannot be minst 3 and longer than 15");
               
                lastName = value;
            }
        }

        // private height property
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // private weight property
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        // person constructor
        public Person(int age, string firstName, string lastName, double height, double weight)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;

        }

    }
}

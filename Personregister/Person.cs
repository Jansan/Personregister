using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Personregister
{
    class Person
    {
       
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

                if (value.Length < 2 && value.Length < 10)

                    throw new ArgumentOutOfRangeException("FirstName cannot be minst 2 and longer than 10 ");
                
                firstName = value;
            }
        }
       
        private string lastName;
       
        public string LastName
        {
            get
            { 
                return lastName; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                
                    throw new ArgumentNullException("Lastname cannot be null");
                if (value.Length < 3 && value.Length < 15)
                    throw new ArgumentOutOfRangeException("LastName cannot be minst 3 and longer than 15");
               
                lastName = value;
            }
        }
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

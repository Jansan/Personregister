using System;
using System.Collections.Generic;
using System.Text;

namespace Personregister
{
    class PersonHandler
    {
        // Set Age
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        // Get Age
        public int GetAge(Person pers)
        {

            return pers.Age;
        }
        // Set FirstName
        public void SetFirstName(Person pers, string firstName)
        {
            pers.FirstName = firstName;
        }
        // Get FirstName
        public string GetFirstName(Person pers)
        {
            return pers.FirstName;
        }
        // Set LastName
        public void SetLastName(Person pers, string lastName)
        {
            pers.LastName = lastName;
        }
        // Get LastName
        public string GetLastName(Person pers)
        {
            return pers.LastName;
        }
        // Set Height
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        // Get Height
        public double GetHeight(Person pers)
        {
            return pers.Height;
        }
        // Set Weight
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        // Get Weight
        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }

        // CreatePerson method
        public Person CreatePerson(int age, string firstName, string lastName, double height, double weight)
        {
            Person person = new Person(age, firstName, lastName, height, weight);
            return person;
            //person.Age = age;
        }
    }
}

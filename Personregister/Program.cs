using System;

namespace Personregister
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //    Person person = new Person();
                //    person.LastName = "jansan";
                //Console.WriteLine(person.LastName);
                PersonHandler personhandler = new PersonHandler();
                
                var person = personhandler.CreatePerson(20, "jansan", "Mariyathas", 173, 80);
                Console.WriteLine(personhandler.GetAge(person));
                Console.WriteLine(personhandler.GetFirstName(person));
                Console.WriteLine(personhandler.GetLastName(person));
                Console.WriteLine(personhandler.GetHeight(person));
                Console.WriteLine(personhandler.GetWeight(person));




                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

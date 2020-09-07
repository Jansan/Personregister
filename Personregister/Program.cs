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
                Console.WriteLine(
                    $"{personhandler.GetAge(person)}" +
                    $"{personhandler.GetFirstName(person)}" +
                    $"{personhandler.GetLastName(person)}" +
                    $"{personhandler.GetHeight(person)}" +
                    $"{personhandler.GetWeight(person)}");
                
                    
            }
            //Tips: kan ha flera catch exceptions, en specifik för ArgumentException och en Exception för andra fel.

            catch(ArgumentException e) //Fångar argument exceptions.
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) //Fångar alla andra typer av exceptions.
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

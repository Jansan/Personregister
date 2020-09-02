using System;

namespace Personregister
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Age = -20;
            Console.WriteLine(person.Age);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new LoginError(),
                new UserNameError(),
                new PasswordError()
            };

            Console.WriteLine("User Error Messages");
            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }

            // 3.4) Polymorfism
            // 11. F: Man ska skriva mindra kod och behöver inte repetera samma kod igen flera gången. skapa base class och general method för att använda flera plats.
            // 12. F: polymorfism kan expandera  kod till avancera program.
            // 13. F: Abstrakt klass kan inte instansiera interface har inte body och finns inte impimation finns inte access modefire alltid public. 
        }
    }
}

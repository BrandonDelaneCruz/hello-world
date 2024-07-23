using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FunctionTest
    {
        /// <summary>
        /// I am a message that the Intelisense can show you when coding :)
        /// </summary>
        /// <param name="userInput">I am telling you about this paramter</param>
        /// <returns>Returns are hard :(</returns>
        public static string AddValues(string userInput)
        {
            if (userInput == "1")
            {
                Console.WriteLine("The limit does not exhisit");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("When scotts boots are a knocking RMI hears everything...>.>");
            }
            else
            {
                Console.WriteLine("Why not two?");
            }

            string foo = $"You selected {userInput}." ;

            return foo;

        }

        public static int SumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}

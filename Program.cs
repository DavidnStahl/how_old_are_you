using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace how_old_are_you
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? (Write numbers): ");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);  // Convert the string to number

            if (age > 18)
            {
                Console.WriteLine("Oh, you are already " + age + " years old!");
            }
            else
            {
                Console.WriteLine("You're only " + age + "... years old");
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace Voter_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voter eligibility");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("Congratulations!! You're eligible for Vote. ");
            }
            else
            {
                Console.WriteLine("Sorry! you need to wait for " + (18 - age) + " years. See you soon. :-)");
            }

            Console.ReadKey();
        }
    }
}

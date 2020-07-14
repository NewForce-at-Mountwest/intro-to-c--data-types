using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name?");
            string firstName = Console.ReadLine();

            int milesPerHour = 30;

            Console.WriteLine($"Hello, {firstName}");

            if(milesPerHour > 20){
                Console.WriteLine("You are extremely fast");
            } else {
                Console.WriteLine("You're pretty fast, but not as fast as Pat");
            }

        }
    }
}

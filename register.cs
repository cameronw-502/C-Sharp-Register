using System;

namespace ConsoleApp1
{
    class Program
    {
        private const string Question = "What would you like to do? \n 1 -- Start Transaction \n 2 -- Call Manager \n 3 -- Till In 4 -- Till Out";

        static String Ask(String Question)
        {
            Console.WriteLine(Question);
            return Convert.ToInt32(Console.ReadLine());
            
        }
        static Int32 Intro()
        {

            Console.WriteLine("Welcome to Cameron's Store!");
            int begin = Ask(Question: Question);
            if (begin == 1) {
                transaction();
            }
            if (begin == 2) {
                help();
            }
            if (begin == 3) {
                tillIn();
            }
            if (begin == 4) {
                tillOut();
            }
            

        }
        static void Main(string[] args)
        {

            Intro();
            
            
        }
        //TODO transaction method
        static void transaction()
        {
            Console.WriteLine("Starting transaction...");
        }
        static void help()
        {
            Console.WriteLine("Calling Manager!");
        }
        static void tillIn()
        {
            Console.WriteLine("Tilling in");
        }
        static void tillOut()
        {
            Console.WriteLine("Tilling out");
        }
    }
}

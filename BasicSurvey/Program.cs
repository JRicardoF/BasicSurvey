using System;

namespace BasicSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            var Name = Console.ReadLine();

            Console.WriteLine("How old are you? (Just insert the number please)");
            var Age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var MonthBirth = Console.ReadLine();

            Console.WriteLine("Your Name is "+ Name + " and you have "+ Age + " years old and you born in " + MonthBirth);
        }
    }
}

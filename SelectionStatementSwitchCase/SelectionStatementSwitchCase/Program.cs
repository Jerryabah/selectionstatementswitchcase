using System;

namespace SelectionStatementSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your favorite school subject!");
            var favSubject = Console.ReadLine();
            
            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is also an interesting subject!");
                    break;
                case "algebra":
                    Console.WriteLine("Algebra is a tough subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {favSubject} sounds fun!");
                    break;
            }

        }
    }
}

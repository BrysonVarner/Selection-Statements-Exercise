using System.Net.Security;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            
            Console.WriteLine("Hello! Would you like to try and guess my favorite number (1 to 1000)?");
            var userInput = int.Parse(Console.ReadLine());

            
            
             if (userInput > favNumber)
             {
                    Console.WriteLine("Too high");
                    Console.WriteLine("Please try again!");
             }

             else if (userInput < favNumber)
             {
                    Console.WriteLine("Too low");
                    Console.WriteLine("Please try again!");
             }
             else
             {
                    Console.WriteLine("You Guessed It!");
             }
            
            
        }
    }
}

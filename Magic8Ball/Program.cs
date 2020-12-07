using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Namespace Container
namespace Magic8Ball
{
    // Class Object Scope
    class Program
    {
        //abstract class Human
        //{
        //    private static string name = "Sawyer";
        //    public static string alias = "Sizzle";
        //    private static int age = 26;
        //}
        //Function

        /// <summary>
        /// Entrypoint for Magic 8-ball program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            
            //Preserving default console color
            ConsoleColor oldColor = Console.ForegroundColor;

            NameProgram();

            //Cleaning Display
            Console.ForegroundColor = oldColor;

            // Create a randomizer
            Random randomObject = new Random();

            Console.WriteLine("{0}", randomObject.Next(10) + 1);

            //Forever LOop
            while (true)
            {
                //Get user question method applied
                string questionString = Quesitoneer();

                int numberOfSecondsToSleep = randomObject.Next(2) + 1;
                Console.WriteLine("Let me think for a moment...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                if (questionString.Length == 0)
                {
                    Console.WriteLine("Write a question dooood.");
                    continue;
                }

                // check if user typed 'quit' as the question
                if (questionString.ToLower() == "quit")
                {
                    break;
                }
                //if question is a request, flip it back to them
                if (questionString.ToLower() == "ask me a question")
                {
                    Console.WriteLine("You first ;)");
                    continue;
                }
                //when response is 'no' ask again
                if (questionString.ToLower() == "no")
                {
                    Console.WriteLine("Just let me do my job, kid...");
                    continue;
                }
                if (questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("Sucks to suck!");
                    break;
                }

                //get a random number
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                // Use one of the 4 random numbers to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("It is decidedly so!");
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("NO");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("YES");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("BIG no");
                            break;
                        }
                }
                
            } // End of While Loop
            

            //Human s1 = new Human();
            //Human s2 = new Human();
            //Human.alias = "Sauce";

            //s1.alias = "Sauce";

        }
        static void NameProgram()
        {
            //Change Console text Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Magic 8-ball (by: Barnacules)");
        }
        /// <summary>
        /// This function will return the text the user types (Get user question method)
        static string Quesitoneer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask me a Question: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}

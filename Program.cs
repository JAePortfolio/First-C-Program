using System;

// Namespace
namespace Number_Guesser
{
    //Main class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            GetAppInfo(); // Calls GetAppInfo function

            GreetUser(); // Calls GreetUser function

            while (true)
            {
                // Set correct number
                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Initialize guess variable
                int guessVar = 0;

                // Loop until correct number guessed
                Console.WriteLine("Guess a number between 1 and 10!");

                while (guessVar != correctNumber)
                {
                    string readNum = Console.ReadLine();

                    // Making sure it's a number
                    if (!int.TryParse(readNum, out guessVar))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Cannot enter strings, only numbers!");

                        continue;
                    }
                    // Cast to int and put in guess
                    guessVar = Int32.Parse(readNum);
                    //Match guess to correct number
                    if (guessVar != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect guess, please try again!");

                    }
                }
                
                PrintColorMessage(ConsoleColor.Yellow, "You guessed the correct number! ;D");

                Console.WriteLine("Do you wish to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                    return;
                    
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "TC2";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change back to white
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask for the user's name
            Console.WriteLine("What is your name?");

            // Get user input and assign it to a string variable
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", input);
        }

        // Print Color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

using System;


//namespace
namespace NumberGuesser
{
    //main class
    class Program
    {
        // entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); // run app info to get it 

            GreetUser(); //ask name and greet

            while (true)
            {
                // Set correct number
                //int correctNumber = 7;

                //create rand ob
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get input
                    string input = Console.ReadLine();

                    // make sure num
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "NOT A NUMBER NIGGA");

                        //keep goin
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct
                    if (guess != correctNumber)
                    {
                        //set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //set succes message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT NIGGA");

                // ask agia
                Console.Write("play again ? [Y or N]");

                //get ans
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
                {
                    return;
                }

            
            }
        }
        // get and displat app info
        static void GetAppInfo ()
        {

            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jay Readman";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();

        }
        // ask name and greet 
        static void GreetUser()
        {
            // ask user name
            Console.WriteLine("what is your name");

            // get name 
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game....", inputName);
        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}

namespace SafeBodaRideSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SafeBodaRideSystem!");
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\nPlease chooce an option:");
                Console.WriteLine("1. Register a Driver");
                Console.WriteLine("2. Register a Passanger");
                Console.WriteLine("3. Exit");
                string userInput = Console.ReadLine();//User Input string
                switch (userInput)
                {
                    case "1"://case 1 to register Anew drive aftre choosing 1
                        Console.WriteLine("You chose to register a new driver");
                        break;

                    case "2":// case 2 to Register a new Passenger after Choosing 2
                        Console.WriteLine("You chose to register a new passenger");
                        break;

                    case "3":// case 3 to exist Application by choosing 3
                        Console.WriteLine("Exiting the application.");
                        keepRunning = false;
                        break;

                    default:// this return error message when input is invalid
               
                        Console.WriteLine("Invalid option. Please try again");
                        break;
                }
            }
            Console.WriteLine("Application has Terminated.");
            //this Console.WriteLine("Application has Terminated.");display this message after existing procees in loop 
        }
    }
}
using System;

namespace Casting_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)

        {   // Asks the user to enter a whole number.
            Console.WriteLine("Please enter a whole number!");

            // Assigns the input to the integer.
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // Shows the number you typed in after Your favorite number is.
            Console.WriteLine("Your favorite number is " + myFavNum);

            // Asks the user if they like video games in a true or false situation.
            Console.WriteLine("Do you like video games? (Please enter 'true' or 'false')");

            // Assigns the response to a boolean.
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Shows the result of the true or false question.
            Console.WriteLine($"It is {isTrue} that I like video games!");
        }
    }
}

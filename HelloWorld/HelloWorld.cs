using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // define a variable as num1
            int num1;
            // define a variable as num2
            int num2;

            // define a string variable to hold the user input as a string
            String userInput;
            // ask the user for the first number
            Console.WriteLine("Enter the first number.");
            // read the user's input as a string
            userInput = Console.ReadLine();
            // convert the string user input to an int
            num1 = Convert.ToInt32(userInput);

            // ask the user for the second number
            Console.WriteLine("Enter the second number.");
            // read the user's input as a string
            userInput = Console.ReadLine();
            // convert the string user input to an int and store it as num2
            num2 = Convert.ToInt32(userInput);

            // define a variable called sum the holds the sum of num1 and num2
            int sum = num1 + num2;
            // print out a message to the screen that shows the 
            // 2 numbers and their sum.
            Console.WriteLine("The sum of "+num1+" and "+num2+" is "+sum);


        }
    }
}

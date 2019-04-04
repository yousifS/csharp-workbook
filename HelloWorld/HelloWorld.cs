using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // print out a greeting to the screen
            Console.WriteLine("Hello my name is Bob.");
            // ask the user for their name
            Console.WriteLine("What is your name?");
            // read the name they type in into a String variable
            String userInput = Console.ReadLine();
            // print a customized message back
            Console.WriteLine("Nice to meet you "+userInput);

        }
    }
}

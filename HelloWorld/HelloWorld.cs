using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name is yousif.");
            Console.WriteLine("What is your name? ");
            String yourName = Console.ReadLine();
            
            if(yourName == "Bob"){
                Console.WriteLine("Really? Bob is the best you could come up with");
            } else {
                Console.WriteLine("Hello "+yourName);
            }
            
        }
    }
}

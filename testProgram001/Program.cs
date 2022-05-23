using System;


namespace CPD
{
    class Program
    {
        static void Main (string[] args)
        {    
            setup();
            interactiveText();
            Console.ReadKey();
        }

        static void interactiveText() {         
            string name;
            string answer1; 
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", I am a Cheezy Scripted Program");
            Console.WriteLine("What is your preferred Colour?");
            answer1 = Console.ReadLine();
            Console.WriteLine("So you like " + answer1 + " mine is Green");
            return;
        }

        static void setup () {
            Console.Title = "CPD Program";
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}




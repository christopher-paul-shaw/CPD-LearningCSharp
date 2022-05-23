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


            Console.WriteLine("What Letter Grade did you get?");
          
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());
            
            switch (grade) {
                case 'A':
                Console.WriteLine("Excellent!");
                break;
                case 'B':
                case 'C':
                Console.WriteLine("Well done");
                break;
                case 'D':
                Console.WriteLine("You passed");
                break;
                case 'F':
                Console.WriteLine("Better try again");
                break;
                default:
                Console.WriteLine("Invalid grade");
                break;
            }
            Console.WriteLine("Your grade is {0}", grade);
            Console.ReadLine();
            return;
        }

        static void setup () {
            Console.Title = "CPD Program 002";
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}




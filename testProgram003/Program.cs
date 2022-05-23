using System;

namespace CPD
{

    class Program
    {

        static void Main (string[] args)
        {
        
            string filename;
            int importType;
            


            Console.WriteLine("What File do you want to import?");
            filename = Console.ReadLine();

            Console.WriteLine("[1] Standard Import, [2] Advanced Import");
            importType = Convert.ToInt16(Console.ReadLine());


            switch(importType)
            {
                case 1:
                    Console.WriteLine("Import File '" + filename + "' as a Standard Import");
                    break;
                case 2: 
                    Console.WriteLine("Import File '" + filename + "' as a Advanced Import");
                    break;
                default:
                    Console.WriteLine("Invalid Import Type Selection");
                    break;
            }



            Console.WriteLine("Import Completed");
            Console.ReadKey();
            

            return;

        }

     

    }


}
using System;

namespace Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            int counter2;

            System.Console.Write("Please enter a name: ");
            String input = Console.ReadLine();

            while (counter < 5) {
                
                counter2 = counter;
                while (counter2 < 10) {
                    Console.WriteLine(input);
                    counter2 = counter2 + 1;

                } 
                Console.WriteLine(" ");
                counter = counter + 1; 
            }
            Console.WriteLine("GoodBye");
            
        }

        
    }
}

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

                counter++;
                
                counter2 = counter;
                while (counter2 < 10) {
                    Console.WriteLine(input);
                    
                    counter2++;

                } 
                Console.WriteLine(" ");

            }
            Console.WriteLine("GoodBye");
            
        }

        
    }
}

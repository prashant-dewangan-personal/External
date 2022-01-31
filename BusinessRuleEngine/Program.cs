using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHOOSE BELOW OPTIONS TO PERFORM A TASK");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Press 1 & Enter: payment for physical product");
            Console.WriteLine("Press 2 & Enter: payment for book");
            Console.WriteLine("Press 3 & Enter: payment for membership");
            Console.WriteLine("Press 4 & Enter: payment for upgrade to a membership");
            Console.WriteLine("Press 5 & Enter: payment for membership or upgrade");
            Console.WriteLine("Press 6 & Enter: payment for video - Learining to Ski");
            Console.WriteLine("Press 7 & Enter: payment for physical product/book");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Printing a packing slip for shipping...");
                    break;
                case "2":
                    Console.WriteLine($"Printing a duplicate packing slip for the royalty department...");
                    break;
                case "3":
                    Console.WriteLine($"Activating membership...");
                    break;
                case "4":
                    Console.WriteLine($"Applying for upgrade...");
                    break;
                case "5":
                    Console.WriteLine($"Emailing the owner informing about activation/upgrade...");
                    break;
                case "6":
                    Console.WriteLine($"Adding a free First Aid video to packing slip...");
                    break;
                case "7":
                    Console.WriteLine($"Generating a commission payment to the agent...");
                    break;
            }
            // Wait for the user to respond before closing.
            Console.WriteLine();
            Console.Write("Press any key to close the application");
            Console.ReadKey();
        }
    }
}

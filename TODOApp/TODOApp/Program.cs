using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var handler = new FileHandler();

            if (args.Length == 0)
            {
                printer.PrintUsage();
            }
            else if (args[0] == "-l")
            {
                printer.PrintTasks(handler.ReadAllTasks());

            }
            else if (args[0] == "-a")
            {
                if (args.Length >= 2)
                {
                    handler.WriteNewTask(args[1]);
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            else if (args[0] == "-r")
            {
                if (args.Length == 2)
                {
                    int input = 0;
                    try
                    {
                        input = Int32.Parse(args[1]);
                        handler.RemoveTask(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to remove: index is not a number.");
                    }
                }
                else if(args.Length == 1)
                {
                    Console.WriteLine("Unable to remove: no index provided.");
                }
            }
            else if (args[0] == "-c")
            {
                handler.CheckTask(Int32.Parse(args[1])); 
            }
            else
            {
                Console.WriteLine("Unsupported argument.");
                printer.PrintUsage();
            }
        }
    }
}

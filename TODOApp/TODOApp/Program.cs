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
                try
                {
                    handler.WriteNewTask(args[1]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            else if (args[0] == "-r")
            {
                try
                {
                    handler.RemoveTask(Int32.Parse(args[1]) - 1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
            }
            else if (args[0] == "-c")
            {
                try
                {
                    handler.CheckTask(Int32.Parse(args[1]) - 1);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: no index provided");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number.");
                }
            }
            else
            {
                Console.WriteLine("Unsupported argument.");
                printer.PrintUsage();
            }
        }
    }
}

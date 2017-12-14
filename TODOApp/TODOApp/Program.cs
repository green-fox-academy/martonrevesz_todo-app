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
                handler.WriteNewTask(args[1]);
            }
            else if (args[0] == "-r")
            {
                handler.RemoveTask(Int32.Parse(args[1]));
            }
        }
    }
}

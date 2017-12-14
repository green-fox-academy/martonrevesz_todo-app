using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOApp
{
    class Printer
    {

        public void PrintUsage()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("==============");
            Console.WriteLine("Command line arguments:");
            Console.WriteLine("-l   Lists all the tasks");
            Console.WriteLine("-a   Adds a new task");
            Console.WriteLine("-r   Removes an task");
            Console.WriteLine("-c   Completes an task");
        }

        public void PrintTasks(string[] myArray)
        {
            int i = 1;
            foreach (string line in myArray)
            {
                Console.WriteLine(i + " - " + line);
                i++;
            }
        }
    }
}

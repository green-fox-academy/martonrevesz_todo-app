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

            if (myArray.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i][0] == '*')
                    {
                        Console.WriteLine(i+1 + " - [X] " + myArray[i].Substring(1));
                    }
                    else
                    {
                        Console.WriteLine(i+1 + " - [ ] " + myArray[i]);
                    }
                }
            }
        }
    }
}

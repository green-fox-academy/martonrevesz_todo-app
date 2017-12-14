using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODOApp
{
    class FileHandler
    {   
        public string[] ReadAllTasks()
        {
            return File.ReadAllLines(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz_todo-app\TODOApp\TODOApp\list.txt");
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODOApp
{
    class FileHandler
    {
        StreamWriter sw = null;
        string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz_todo-app\TODOApp\TODOApp\list.txt";

        public string[] ReadAllTasks()
        {
            return File.ReadAllLines(path);
        }

        public void WriteNewTask(string line)
        {
            sw = new StreamWriter(path, true);
            sw.WriteLine(line);
            sw.Close();
        }

        public void RemoveTask(int index)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                sw = new StreamWriter(path);

                for (int i = 0; i < index; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                for (int i = index + 1; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Unable to remove: index is out of bound");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to remove");
            }
            sw.Close();
        }

        public void CheckTask(int index)
        {
            string[] lines = File.ReadAllLines(path);
            sw = new StreamWriter(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i == (index - 1))
                {
                    if (lines[i][0] != '*')
                    {
                        sw.WriteLine("*" + lines[i]);
                    }
                    else
                    {
                        sw.WriteLine(lines[i]);
                    }
                }
                else
                {
                    sw.WriteLine(lines[i]);
                }
            }
            sw.Close();
        }
    }
}

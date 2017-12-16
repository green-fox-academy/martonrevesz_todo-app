using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace TODOApp
{
    public class FileHandler
    {
        StreamWriter sw = null;
        
        public string[] ReadAllTasks(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void WriteNewTask(string fileName, string line)
        {
            sw = new StreamWriter(fileName, true);
            sw.WriteLine(line);
            sw.Close();
        }

        public void RemoveTask(string fileName, int index)
        {
            string[] lines = File.ReadAllLines(fileName);
            try
            {
                sw = new StreamWriter(fileName);
                var linesList = lines.ToList();
                linesList.Remove(lines[index]);
                lines = linesList.ToArray();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Unable to remove: index is out of bound");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to remove");
            }
            for (int i = 0; i < lines.Length; i++)
            {
                sw.WriteLine(lines[i]);
            }
            sw.Close();
        }

        public void CheckTask(string fileName, int index)
        {
            string[] lines = File.ReadAllLines(fileName);
            sw = new StreamWriter(fileName);
            try
            {
                if (lines[index][0] != '*')
                {
                    lines[index] = "*" + lines[index];
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Unable to check: index is out of bound");
            }
            for (int i = 0; i < lines.Length; i++)
            {
                sw.WriteLine(lines[i]);
            }
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SamarAA.Sprint5.Task6.V26.Lib
{
    public class DataService : ISprint5Task6V26
    {
        public int LoadFromDataFile(string path)
        {
           int count = 0;

            /*using (StreamReader reader = new StreamReader(path))
            {
                 string line;
                 while ((line = reader.ReadLine()) != null)
                 {
                     for (int i = 0; i < line.Length; i++)
                     {
                         if (line[i] == '?')
                         {
                             count++;
                         }
                     }
                 }
            }
            return count;
            */
            string str = File.ReadAllText(path);
            foreach(char ch in str)
            {
                if (ch == '?')
                {
                    count++;
                }
            }
            return count;
        }
    }
}

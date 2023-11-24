using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SamarAA.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint5\Tyuiu.SamarAA.Sprint5.Task7.V16\bin\Debug\OutPutFileTask7V16.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            string text = File.ReadAllText(path);
            string[] str = text.Split(' ');
            

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                foreach (char ch in str[i])
                {
                    if (char.IsLetterOrDigit(ch))
                    {
                        count++;
                    }
                }
                if (count == 2 && i!=str.Length-1)
                {
                    strLine += "XY "; 
                }
                else if (count == 2 && i == str.Length - 1)
                {
                    strLine += "XY";
                }
                else if(count != 2 && i == str.Length - 1)
                {
                    strLine += str[i];
                }
                else if (count != 2 && i != str.Length - 1)
                {
                    strLine += str[i] + " ";
                }  
            }
            File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
            return pathSaveFile;
        }
    }
}

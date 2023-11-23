using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SamarAA.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = double.Parse(str);
            double res = Math.Round(Math.Pow(x, 3) * 1.2 * x + 2, 3);

            return res;
        }
    }
}

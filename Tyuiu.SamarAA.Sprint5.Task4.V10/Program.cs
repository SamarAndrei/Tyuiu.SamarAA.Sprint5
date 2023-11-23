using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SamarAA.Sprint5.Task4.V10.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint5.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt в котором есть         *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* Х в формуле y = x^3 * 1,2x + 2. Вычислить значение по формуле           *");
            Console.WriteLine("*  и вернуть полученный результат на консоль.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

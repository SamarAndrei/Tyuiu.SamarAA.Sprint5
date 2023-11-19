using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SamarAA.Sprint5.Task1.V20.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint5.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана функция F(x) = 5x + 2,5                                            *");
            Console.WriteLine("*                    ---------- + 2x + cos(x)                             *");
            Console.WriteLine("*                    sin(x) + 3                                           *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапозоне [-5;5] с шагом 1. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            string[] lines = File.ReadAllLines(@"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint5\Tyuiu.SamarAA.Sprint5.Task1.V20\bin\Debug\OutPutFileTask1.txt");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}  |", startValue, lines[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}

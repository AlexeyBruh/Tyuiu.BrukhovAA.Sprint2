using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint2.Task4.V25.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task4.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                            *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с             *");
            Console.WriteLine("* с использованием тернарного оператора, где польхователь вводит значение*");
            Console.WriteLine("* переменных x, y с клавиатуры.                                          *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.            *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = Convert.ToInt32(Console.ReadLine());
            double res = Math.Round(ds.Calculate(x, y), 3);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Требуемое значение  = " + res);
            Console.ReadKey();
        }
    }
}

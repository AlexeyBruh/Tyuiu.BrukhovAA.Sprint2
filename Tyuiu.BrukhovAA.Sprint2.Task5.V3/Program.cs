using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task5.V3
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
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Составить программу, которая в зависимости от порядкового номера дня   *");
            Console.WriteLine("* недели (1, 2, …, 7) выводит на экран его название                      *");
            Console.WriteLine("* (понедельник, вторник, …, воскресенье).                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите номер дня недели");
            int x = Convert.ToInt32(Console.ReadLine());
            string res;

            if((x < 1) || (x > 7))
            {
                res = "Значение введено неверно";
            }
            else
            {
                res = "День недели: " + ds.FindDayName(x);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}

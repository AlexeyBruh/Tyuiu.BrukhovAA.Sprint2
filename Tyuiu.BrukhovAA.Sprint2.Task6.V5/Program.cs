using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.BrukhovAA.Sprint2.Task6.V5
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
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("*  оператора switch и вычисляет требуемое значение и возвращает результат*");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите порядковый номер карты");
            int x = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((x < 6) || (x > 14))
            {
                res = "Значение введено неверно";
            }
            else
            {
                res = "Достоинство карты: " + ds.FindCardValue(x);
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

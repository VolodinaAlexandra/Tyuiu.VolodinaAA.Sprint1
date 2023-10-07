using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.VolodinaAA.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#1 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:Пусть k – целое     *");
            Console.WriteLine("* от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в          *");
            Console.WriteLine("* зависимости от того, на какой день недели (понедельник,..., воскресенье)*");
            Console.WriteLine("* приходится k-й день невисокосного года, в котором 1 января – понедельник*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите день невисокосного года:                                        *");
            int k = int.Parse(Console.ReadLine());
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("На "+ k + "-й день невисокосного года приходится " + ds.Calculate(k) + "-й день недели");
            Console.WriteLine("***************************************************************************");


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint4.Task2.V11.Lib;

namespace Tyuiu.PopkovSV.Sprint4.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Попков С. В. | ИСТНб-23-1";

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #2                                                                     *");
            Console.WriteLine("* Вариaнт #11                                                                    *");
            Console.WriteLine("* Выполнил: Попков Сергей Вадимович | ИСТНб-23-1                                 *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный случайными     *");
            Console.WriteLine("* в диапазоне от 3 до 8 подсчитать сумму четных элементов массива.               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int len;
            Console.Write("Введите кол-во элементов: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(3, 8);
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Результат сложения чётных чисел: " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
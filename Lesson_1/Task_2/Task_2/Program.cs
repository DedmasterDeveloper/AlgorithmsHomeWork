using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /*
     * Найти максимальное из четырех чисел. Массивы не использовать.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 7;
            int number2 = 9;
            int number3 = 3;
            int number4 = 11;

            Console.WriteLine($"У нас есть 4 переменные, number1 = {number1}, number2 = {number2}, number3 = {number3}, number4 = {number4}");

            if(number1 > number2)
            {

            }
            else
            {
                number1 = number2;
            }
            if(number1 > number3)
            {

            }
            else
            {
                number1 = number3;
            }
            if (number1 > number4)
            {

            }
            else
            {
                number1 = number4;
            }
            Console.WriteLine($"Максимальное число: {number1}");
            Console.ReadLine();
        }
    }
}

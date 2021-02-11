using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /*
     *Задание:
     *Написать программу обмена значениями двух целочисленных переменных:
     *a. с использованием третьей переменной;
     *b. *без использования третьей переменной.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numebr1 = 6;
            int number2 = 7;
            Console.WriteLine($"Переменная number1 = {numebr1}, переменная number2 = {number2}");
            int number3 = number2;
            number2 = numebr1;
            numebr1 = number3;
            Console.WriteLine($"Переменная number1 = {numebr1}, переменная number2 = {number2}");

            int numebr4 = 3;
            int number5 = 8;
            Console.WriteLine($"Переменная number4 = {numebr4}, переменная number5 = {number5}");
            numebr4 += number5;
            number5 = numebr4 - number5;
            numebr4 -= number5;
            Console.WriteLine($"Переменная number4 = {numebr4}, переменная number5 = {number5}");
            Console.ReadLine();
        }
    }
}

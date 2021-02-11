using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    /*
     * Задание:
     * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес:");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост:");
            double Height = Convert.ToDouble(Console.ReadLine());
            double mass_index = Weight / (Height * Height);
            Console.WriteLine($"Ваш индекс массы = {mass_index}");
            Console.ReadLine();


        }
    }
}

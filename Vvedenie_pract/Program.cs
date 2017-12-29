using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vvedenie_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            Console.WriteLine("Рыспеков Жаслан");
        }

        private static void Task2()
        {
            int number1, number2;
            Console.WriteLine("Ведите 1 число");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма этих чисел равна ", number1 + number2);
        }
    }
}

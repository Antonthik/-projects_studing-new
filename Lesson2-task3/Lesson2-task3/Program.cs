using System;

namespace Lesson2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число.");
            string inText = Console.ReadLine();

            int inNumber=Convert.ToInt32(inText);

            if (inNumber%2!= 0) {
                Console.WriteLine("Число не является четным.");
            }
            else
            {
                Console.WriteLine("Число четное.");
            }

        }
    }
}

using System;

namespace Lesson3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "olleH";
            string strNew = "";
            char[] chr = new char[str.Length];//создаем массив символов
            int j = 0;
            for (int i = str.Length - 1; i>= 0; i--)//Используем обратное чтение массива
            {
                chr[j]= str[i];//заполняем массив символов
               // Console.WriteLine($"{str[i]}");
                j++;
            }

            strNew = new string(chr);//собираем массив символов в строку
            Console.WriteLine($"Было {str}");
            Console.WriteLine($"Стало {strNew}");

        }
    }
}

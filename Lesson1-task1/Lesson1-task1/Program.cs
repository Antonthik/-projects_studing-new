using System;

namespace Lesson1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выводим строку на дисплей для пользователя
            Console.WriteLine("Введите свое имя.");
            // Читаем имя вводимое пользователем
            string nameUser = Console.ReadLine();
            //Определяем текущую дату и время
            DateTime toDay = DateTime.Now;
            //Применяем интерполяцию для построения динамической строки (используем - $ перед строкой, и переменные указываем - {})
            Console.WriteLine($"{nameUser}, привет сегодня {toDay} !"); 
        }
    }
}

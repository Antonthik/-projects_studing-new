using System;

namespace Lesson2_task2
{
    //Создаем перечисление месяцев и задаем их нумерацию
    enum mounth
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод номера месяца
            Console.WriteLine("Введите номер месяца");
            string number = Console.ReadLine();
            //Конвертируем в число введенный текст
            int numberM = Convert.ToInt32(number);

            //Проверка вхождения введенного числа в заданный диапозон
            if (numberM >= 1 && numberM <= 12)
            {
                //Вывод элемента перечисления месяцев - выводим наименование по индексу
                Console.WriteLine($"Был выбран месяц: {(mounth)numberM} ");
            }
            else
            {
                Console.WriteLine("Некорректное число введено.");
            
            }
            
        }
    }
}

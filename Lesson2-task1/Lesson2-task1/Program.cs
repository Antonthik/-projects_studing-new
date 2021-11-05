using System;

namespace Lesson2_task1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string inText;
            //Вводим минимальную температуру
            Console.WriteLine("Введите минимальную температуру дня");
            inText = Console.ReadLine();
            decimal tempMin = Convert.ToDecimal(inText);

            //Вводим минимальную температуру
            Console.WriteLine("Введите максимальную температуру дня");
            inText = Console.ReadLine();
            decimal tempMax = Convert.ToDecimal(inText);

            //Вводим дату наблюдений
            Console.WriteLine("Введите дату наблюдения");
            inText = Console.ReadLine();
            // Определяем текущую дату
            DateTime dateT = Convert.ToDateTime(inText);
            // Определяем среднюю температуру
            decimal tempAvr = (tempMin + tempMax) / 2;
            // Определяем текущий месяц
            string mounthCur = dateT.ToString("MM");
            

            Console.WriteLine($"Средняя температура {tempAvr} , за дату: {dateT.ToString("dd.MM.yy")}");
            //Console.WriteLine($"Текущий месяц {mounthCur}");

            // Если в зимний день температура > 0, тогда определяем зимний период - как дождливый
            if (((mounthCur == "12") || (mounthCur == "01") || (mounthCur == "02")) && tempAvr > 0)
            {
                Console.WriteLine("Текущая зима - дождлива");
            }
           
            



        }
    }
}

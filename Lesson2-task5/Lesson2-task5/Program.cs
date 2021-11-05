using System;

namespace Lesson2_task5
{
    // Перечисление дней недели
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,  // 0
        Monday = 0b_0000_0001,  // 1
        Tuesday = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday = 0b_0000_1000,  // 8
        Friday = 0b_0001_0000,  // 16
        Saturday = 0b_0010_0000,  // 32
        Sunday = 0b_0100_0000,  // 64
        Weekend = Saturday | Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем комбинации рабочих дней офисов - используем бинарное-или, чтобы сложить комбинацию рабочи дней офисов
            Days ofice1 = Days.Monday | Days.Thursday| Days.Friday;
            Days ofice2 = Days.Tuesday | Days.Wednesday | Days.Sunday;
            Days ofice3 = Days.Saturday | Days.Wednesday | Days.Sunday;

            //Создаем комбинацию дней посещения офисов
            Days myvisit = Days.Monday | Days.Tuesday; //хочу поситить офисы в определенные дни
            //Console.WriteLine(ofice1);
            //Console.WriteLine(ofice2);

            //Используем бинарное-и, чтобы отобрать нужные офисы для посещения
            Days myvisitOffice1 = ofice1 & myvisit;
            Days myvisitOffice2 = ofice2 & myvisit;
            Days myvisitOffice3 = ofice3 & myvisit;

            // Проверяем офисы, которые можем посетить
            if (myvisitOffice1 != Days.None) {
                Console.WriteLine($"Посещение офиса1 возможно {myvisitOffice1}");
            }

            if (myvisitOffice2 != Days.None)
            {
                Console.WriteLine($"Посещение офиса2 возможно {myvisitOffice2}");
            }

            if (myvisitOffice3 != Days.None)
            {
                Console.WriteLine($"Посещение офиса2 возможно {myvisitOffice3}");
            }
        }
    }
}

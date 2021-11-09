using System;

namespace Lesson4_task3
{
    class Program
    {
        //Программа для определения времени года по номеру месяца
        static void Main(string[] args)
        {
            startProg();
        }
        
        static void startProg()
        {
            while(true){
                
                Console.WriteLine("Введите номер месяца.Для выхода нажмите 0.");
                string input = Console.ReadLine();
                int mounthNum = Convert.ToInt32(input);

                //Проверка корректности ввода
                if (mounthNum >= 1 && mounthNum<=12) {
                    Console.WriteLine($"{seasons(mounthNum)}");// вызов функции и вывод результата
                }
                else
                {
                    Console.WriteLine("Некорректное значение месяца.");
                }

                //Выходим из программы 
                if (input == "0") {
                    return;
                }
               
            }
           
            
        }

        static string seasons(int mounthNumb)
        {
            string season = "";

            if (mounthNumb == 12 || mounthNumb == 1|| mounthNumb == 2)
            {
                 season = "Winter";
            }
            else if (mounthNumb == 3 || mounthNumb == 4 || mounthNumb == 5)
            {
                 season = "Spring";
            }
            else if(mounthNumb == 6 || mounthNumb == 7 || mounthNumb == 8) 
            {
                  season = "Summer";
            }
            else if(mounthNumb == 9 || mounthNumb == 10 || mounthNumb == 11)
            {
                  season = "Autumn";
            }

            return season;
        }
    }
}

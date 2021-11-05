using System;

namespace Lesson3_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем конфигурацию кораблей и координаты
            string[] ships = new string[]
            {
               "X+0+0",
               "XX+0+5",
               "XXX+2+0",
               "X+2+4",
               "XX+4+0",
               "XXX+9+6",
               "X+9+1",
               "XX+7+1",
               "XXXX+6+3",
               "X+4+9"
            };

            string[,] place = new string[10, 10]; // массив поля


            for (int k = 0; k < ships.Length; k++)// перебор каждого корабля
            {
                string[] arr = ships[k].Split("+");
                string ship = arr[0];
                int y = Convert.ToInt32(arr[1]);//начальная таблица по вертикали
                int x = Convert.ToInt32(arr[2]);// начальная точка по горизонтали
                int l = ship.Length;//размер корабля
                bool flag = false;

                //рисуем по координатам корабли
                for (int i = 0; i < place.GetLength(0); i++)
                {
                    for (int j = 0; j < place.GetLength(1); j++)
                    {
                        if (place[i, j]!="X") // Если ячейка заполнена, то выводим ноль
                        {
                            place[i, j] = "O";
                        }

                        if (x==j && y == i && flag==false)
                        {
                            flag = true; // флаг начала записи 
                        }

                        if (flag == true && l>0)
                        {
                            place[i, j] ="X"; //рисуем часть корабля 
                            l--;
                        }

                        //Console.Write(place[i, j]);
                    }
                    //Console.WriteLine();
                }
            }

            //Выводим поле с кораблями
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    Console.Write(place[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}

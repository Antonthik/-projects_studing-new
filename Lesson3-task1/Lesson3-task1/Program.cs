using System;

namespace Lesson3_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr0 = new int[] { 10, 225, 32, 99, 11, 1 };//определяем набор цифр и формируем одномерный массив
            int[,] arr = new int[arr0.Length, arr0.Length];//определяем размерность массива по одномерному массиву

            for (int i = 0; i < arr.GetLength(0); i++)// цикл строк
            {
                for(int j=0;j< arr.GetLength(1); j++)//цикл столбцов
                {
                    if (i == j)
                    {
                        arr[i, j] = arr0[i];// заполняем диагональ матрицы числами из массива arr0
                    }
                    else
                    {
                        arr[i, j] = 0;// заполняем остальные элементы нулями
                    }
                    Console.Write(arr[i,j]);//выводим текщий элемент
                }
                System.Console.WriteLine();//завершаем вывод строки
            }
           
        }
    }
}

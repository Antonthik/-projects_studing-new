using System;

namespace Lesson4_task4
{
    class Program
    {
        //Программа нахождения числа Фибоначчи по номеру - используем рекурсивный вызов метода
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер числа Фибоначчи.");
            string input= Console.ReadLine();
            int num = Convert.ToInt32(input);
            if (num <=0 )
            {
                num = 1;
            }
 

            var numbF = GetFib(0,1, num-3);
            Console.WriteLine($"Число Фибоначчи для {num} = {numbF}");
        }

        //*Метод нахождения числа Фибоначчи - используем рекурсивный вызов
        //Задаем первые два числа Фибоначчи для расчетого следующего
        //count - убывающий счетчик итераций,выходим при достижении нуля.
        //
        //*//

        static int GetFib(int a,int b, int count)
        {
            
            // Выход из рекурсионного вызова
            if (count == 0) {
                return a + b; 
            }

            int c = b;
            b = a + b; // расчет нового значения
            a = c;

            //передаем новое значение и предыдущее - счетчик уменьшаем
            int  n =  GetFib(a,b, count - 1); // Вызываем метод из самого себя

            //Console.WriteLine(n);
            return n;

        }
    }
}

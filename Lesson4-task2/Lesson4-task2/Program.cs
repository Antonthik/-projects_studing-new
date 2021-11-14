using System;
// Программа для вычисления суммы чисел введенных одной строкой через пробел.
namespace Lesson4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumbers = 5;
            Console.WriteLine($"Ведите числа в строку, разделяя их пробелом. Количество чисел не более {maxNumbers}");
            string input = Console.ReadLine();

           


            double summ = sumArr(input, maxNumbers);
            Console.WriteLine($"Сумма равна {summ}") ;
        }

        static double sumArr(string str, int maxNumbers)
        {
            // string[] arr = str.Split(" ");
            double[] arr = split_32(str, maxNumbers);
            double summ = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {               
                    summ = summ + Convert.ToDouble(arr[i]);               
            }
                return summ;
            
        }
        //разбиваем строку с цифрами на цифровой массив разделитель символов пробел.
        static double[] split_32(string str, int maxNumbers)
        {
            string strNum = "";
            int sizarrNumbers = maxNumbers; // размер массива чисел
            Boolean flag = false;
            double[] arrNumbers = new double[sizarrNumbers];// массив чисел
            int j = 0;

            // Цикл строки - перебираем каждый символ строки
            for (int i = 0; i < str.Length; i++)
            {
                char charCur = str[i];
                if (charCur != ' ' && flag == false)
                {                   
                    flag = true; // флаг начала новой цифры
                } 
                
                // формируем цифру - проверяем символ на число и запятую
                if (flag == true && (charCur == '1' || charCur == '2'|| charCur == '3'|| charCur == '4'|| charCur == '5'|| charCur == '6'
                    || charCur == '7'|| charCur == '8'|| charCur == '9' || charCur == '0' || charCur == ','))

                {
                    strNum = strNum + charCur;   //формируем цифру            
                }

                // прерываем программу если количество введенных цифр превысело предел 
                if (j >= sizarrNumbers) 
                {
                    Console.WriteLine($"Достигнут предел по количеству чисел, массив состоит из {sizarrNumbers} чисел");
                    break;
                }

                //проверка и запись в массив чисел - 
                if ((charCur == ' ' || i == str.Length - 1) && flag == true)
                {
                    if (strNum != "")
                    {
                        arrNumbers[j] = Convert.ToDouble(strNum);
                        j++; 
                        flag = false;
                        strNum = "";
                    }



                }

            }

            return arrNumbers;
        }
    }
}

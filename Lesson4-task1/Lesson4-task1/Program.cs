using System;

namespace Lesson4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = arrayFIO(); // формируем входной массив
            splitFIO(arr); // вывод общей строки

        }
        //Функция формирующая общую строку ФИО и вывод на дисплей
        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = ($"{firstName} {lastName} {patronymic}");            
            Console.WriteLine(fullName);
        }

        //Функция формирования входных данных
        static String[] arrayFIO (){
            String[] arr = new string[] { 
            "Иванов Иван Иванович",
            "Сидоров Петр Сергеевич",
            "Петрова Татьяна Сергеевна"};
            return arr;
            }

        //Функция разбиения строки на ФИО и передача функцию вывода на дисплей
        static void splitFIO( string[] arr)
        {
            for(int i=0;i< arr.Length; i++)
            {
                if (arr[i]!="") {
                    string[] arrSplit = arr[i].Split(" ");
                    if (arrSplit.Length == 3){
                        GetFullName(arrSplit[0], arrSplit[1], arrSplit[2]); // передача фамилии, имени, отчества  в функцию объединения.
                    }
                }
            }
        }


    }
}

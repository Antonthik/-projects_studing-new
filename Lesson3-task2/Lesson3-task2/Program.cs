using System;

namespace Lesson3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входные данные для заполнения контактов телефонной книги
            string[] info =
                 {
                    "Иванов+4440001/ivanov@un.com",
                    "Петров+4440002/petrov@un.com",
                    "Сидоров+4440003/sidorov@un.com",
                    "Петрова+4440004/petrov@un.com",
                    "Филиппова+4440005/fillipova@un.com",
                    "Егоров+4440006/egorov@un.com",
                    "Козлова+4440007/kozlova@un.com",
                };

            string[,] contacts = new string[5, 2]; // массив телефонной книги

            // заполняем массив телефонной книги
            for (int i = 0; i < contacts.GetLength(0); i++)
            {
                string[] subs = info[i].Split("+");
                contacts[i, 0] = subs[0]; //заполняем фамилию
                contacts[i, 1] = subs[1]; //заполняем телефон и электронную почту
            }

            // Начало
            Console.WriteLine("Для выхода из поиска контактов нажмите ноль.");
            while (true)
            {
                Console.WriteLine("Введите фамилию для поиска.");
                string input = Console.ReadLine();
                bool flagOk = false;//флаг результата поиска

                //Выход из программы по запросу пользователя
                if (input == "0")
                {
                    return;
                }

                // Цикл поиска контакта
                for (int i = 0; i < contacts.GetLength(0); i++)
                {
                    if (input == contacts[i, 0])//Условие нахождения контакта
                    {

                        Console.WriteLine($"Контакт найден {contacts[i, 0]} {contacts[i, 1]}");//Вывод на экран контакт
                        flagOk = true;
                    }

                    if (flagOk == true)
                    {
                        Console.WriteLine("Поиск завершен. Для выхода нажмите 0");
                        break;// выход из цикла поиска

                    }

   

                }

                if (flagOk == false)
                {
                    Console.WriteLine("Контакт не найден. Для выхода нажмите 0");
                }
            }
        }
    }
}


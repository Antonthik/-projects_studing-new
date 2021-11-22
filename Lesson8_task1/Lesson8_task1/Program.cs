using System;
using System.IO;
using System.Text.Json;
namespace Lesson8_task1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            string pathDir = @"C:\!UserFolder\";
            createFolder(pathDir);

            if (File.Exists(pathDir + $"{name}.txt") == false)
            {
                Console.WriteLine("Введите возраст");
                string input = Console.ReadLine();
                int age = Convert.ToInt32(input);
                Console.WriteLine("Введите род деятельности");
                string work = Console.ReadLine();

                Peoples people = new Peoples(name, age, work);
                serial_json(people, $"{name}.txt", pathDir);
            }
            else
            {
                //Console.WriteLine($"{name},я с Вами уже знаком");
                Peoples people = readTasks(pathDir, $"{name}.txt");
                Console.WriteLine($"{name},я с Вами уже знаком.Вам {people.Age},и занятие у вас - {people.Work}");
            }



        }

        static void serial_json(Peoples task, string fileName, string pathDir)
        {
            //string pathDir = @"C:\!test\";
            //string fileName = "tasks.json";
            string pathFile = Path.Combine(pathDir, fileName);

            // if (File.Exists(pathFolder))
            // {
            //     File.Delete(pathFolder);
            // }
            string json = JsonSerializer.Serialize(task);
            File.AppendAllText(pathFile, $"{json} {(char)13}");
        }

        //Читаем задачи,десериализация json
        static Peoples readTasks(string pathDir, string fileName)
        {
            string pathFile = Path.Combine(pathDir, fileName);
            if (File.Exists(pathFile))
            {
                //File.Delete(pathFolder);
                string json = File.ReadAllText(pathFile);
                Peoples task = JsonSerializer.Deserialize<Peoples>(json);              
                return task;
            }
            else
            {
                return null;
            }
        }

        //Создаем рабочую папку
        static void createFolder(String pathDir)
        {
            if (Directory.Exists(pathDir) == false)
            {
                Directory.CreateDirectory(pathDir);
               // Console.WriteLine("Папка создана.");
            }
            else
            {
                //Console.WriteLine("Папка ранее создана.");
            }
        }

    }
}

using System;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson5_task05
{
    //Список задач ToDo лист
    class Program
    {
        static void Main(string[] args)
        {
            string pathDir = @"C:\!test\";
            createFolder(pathDir);


            Console.WriteLine("Введите: 1-редактирование задач; 2-новая задача");
            string input = Console.ReadLine();

            if (input == "1")
            {
                editTasks(pathDir);
            }else if (input=="2")
            {
                enterNewTask(pathDir);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }





        }
     //Создаем рабочую папку
    static void createFolder(String pathDir)
        {
            if (Directory.Exists(pathDir)==false)
            {
                Directory.CreateDirectory(pathDir);
                Console.WriteLine("Папка создана.");
            }
            else
            {
                Console.WriteLine("Папка ранее создана.");
            }
        }

        //Редактируем задачу
    static void editTasks(string pathDir)
    {

        ToDo[] Tasks = readTasks(pathDir, "tasks.json");

        if (Tasks != null)
        {
            Console.WriteLine("Введите номер задачи для пометки как исполнено");
            string input = Console.ReadLine();
            int numb = Convert.ToInt32(input);

            if (numb >= 0 && numb <= Tasks.Length - 1)
            {
                ToDo task = Tasks[numb];
                if (task.IsDone == false)
                {
                        task.IsDone = true;
                        serial_json_arr(Tasks, "tasks.json", pathDir);
                        Console.WriteLine("Данные обновлены.");
                    }
                    else
                    {
                        Console.WriteLine("Обновление отменено.");
                    }

                }
                
        }
            else
            {
                Console.WriteLine("Нет данных для редактирования.");
            }
        }

        //Новая задача
        static void enterNewTask(string pathDir)
        {
            ToDo[] Tasks = readTasks(pathDir, "tasks.json");// вызываем таблицу введенных задач
            Console.WriteLine("Введите наименование задачи.");
                string input = Console.ReadLine();
                ToDo task = new ToDo(input, false);
                task.Getmetod();


                serial_json(task, "tasks.json", pathDir);
                // serial_xlsm(task, "tasks.xml");
                // serial_binar(task, "tasks.bin");
           
        }

        static bool flagT(string f)
        {
            bool flagT = false;
            if (f == "1")
            {
                flagT = true;
            }

            return flagT;
        }

        //Читаем задачи,десериализация json
        static ToDo[] readTasks(string pathDir,string fileName)
        {
            string pathFile = Path.Combine(pathDir, fileName);
            if (File.Exists(pathFile))
            {
                //File.Delete(pathFolder);
                string[] json = File.ReadAllLines(pathFile);
                ToDo[] Tasks = new ToDo[json.Length];
                for (int i = 0; i < json.Length; i++)
                {
                    ToDo task = JsonSerializer.Deserialize<ToDo>(json[i]);
                    Console.WriteLine($"{i} { task.Title} {task.IsDone }");
                    Tasks[i] = task;
                }
                return Tasks;
            }
            else
            {
                return null;
            }
        }

        //Перезаписываем файл json массива объектов
        static void serial_json_arr(ToDo[] tasks, string fileName, string pathDir)
        {

            string pathFile = Path.Combine(pathDir, fileName);

            if (File.Exists(pathFile))
            {
                 File.Delete(pathFile);
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                string json = JsonSerializer.Serialize(tasks[i]);
                File.AppendAllText(pathFile, $"{json} {(char)13}");
            }
           
        }

        //сериализация json
        static void serial_json(ToDo task,string fileName, string pathDir)
        {
            //string pathDir = @"C:\!test\";
            //string fileName = "tasks.json";
            string pathFile = Path.Combine(pathDir, fileName);

           // if (File.Exists(pathFolder))
           // {
           //     File.Delete(pathFolder);
           // }
            string json = JsonSerializer.Serialize(task);
            File.AppendAllText(pathFile, $"{json} {(char)13}" );
        }



        static void serial_xlsm(ToDo task, string fileName)
        {
            string pathDir = @"C:\!test\";            
            string pathFile = Path.Combine(pathDir, fileName);

            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo));
            serializer.Serialize(stringWriter, task);
            string xml = stringWriter.ToString();
           // File.WriteAllText("house.xml", xml);
            File.AppendAllText(pathFile, $"{xml} {(char)13}");


        }

        static void serial_binar(ToDo task, string fileName)
        {
            string pathDir = @"C:\!test\";
            string pathFile = Path.Combine(pathDir, fileName);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream(fileName, FileMode.Append), task);
        }
    }
}

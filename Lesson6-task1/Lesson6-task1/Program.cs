using System;
using System.Diagnostics;

namespace Lesson6_task1
{
    //Программа по мониторингу и закрытию открытых процессов
    class Program
    {
        static void Main(string[] args)
        {
           // Вызываем список открытых процессов
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length; i++)
            {
                int id = processes[i].Id;
                string name=processes[i].ProcessName;
                //DateTime starttime = processes[i].StartTime;
                Console.WriteLine($"{i} {id} {name} ");

            }
            choiseForClose();




        }

        //Метод для выбора способа закрытия процесса - по имени или ID
        static void choiseForClose()
        {
            Console.WriteLine("1 - закрытие процесса по id; 2 - закрытие по имени");
            string input = Console.ReadLine();
            
            if (input == "1"){
                Console.WriteLine("Введите ID процесса:");
                string inp = Console.ReadLine();
                int id = Convert.ToInt32(inp);
                Process proc = Process.GetProcessById(id);
                closeProcesse(proc);
            }
            else if (input=="2")
            {
                Console.WriteLine("Введите имя процесса:");
                string inp = Console.ReadLine();
                string name = inp;
                Process[] proceses = Process.GetProcessesByName(name);
                foreach (Process proc in proceses)
                {
                    closeProcesse(proc);
                }

            } 
        }
        
        //Метод закрытия заданного процесса
        static void closeProcesse(Process proc)
            
        {
            try
            {
                proc.Kill();//жесткое закрытие
                            //proc.WaitForExit();//закрываем процесс с ожиданием
                            //Console.WriteLine(proc.ExitCode); // 0
            }
            catch (Exception)
            {
                Console.WriteLine($"Произошла ошибка: ");
                
            }



        }
    }
}

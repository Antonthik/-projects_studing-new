using System;
using System.IO;
namespace Lesson5_task04
{
    //Выгрузка дерева ресурса
    class Program
    {
        static void Main(string[] args)
        {
            string pathDir = @"C:\!test\";
            string[] arrDir = Directory.GetFileSystemEntries(pathDir,"*.*", SearchOption.AllDirectories);

           
            Console.WriteLine("Введите метод выгрузки: 1- метод рекурсии, 2- метод циклом");
            string input = Console.ReadLine();

            string fileName = "text.txt";
            string pathFolder = Path.Combine(pathDir, fileName);

            if (File.Exists(pathFolder))
            {
                File.Delete(pathFolder);
            }



            if (input == "1")
            {

                WhriteInFile_recurs(arrDir, arrDir.Length - 1, pathFolder);
            }
            else if (input == "2")
            {
                WhriteInFile_cikl(arrDir, pathFolder);
            }

           
        }

        //Выгрузка содержимого папки методом рекурсии
        static void  WhriteInFile_recurs(string[] arr,int count, string pathFolder)
        {
            if (count == -1)
            {
                return;
            }

           // string pathFile = Path.Combine(workDir, fileName);//создаем путь к файлу
            File.AppendAllText(pathFolder, $"{arr[count]} {(char)13}");// пишем текст в файл
            WhriteInFile_recurs(arr, count - 1, pathFolder);//рекурсионный вызов
        }

        static void WhriteInFile_cikl(string[] arr, string pathFolder)
        {
            //string pathFile = Path.Combine(workDir, fileName);//создаем путь к файлу

            for (int i = 0; i < arr.Length; i++)
            {
                File.AppendAllText(pathFolder, $"{arr[i]} {(char)13}");// пишем текст в файл
            }
           
           
         
        }

    }
}

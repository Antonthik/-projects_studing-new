using System;
using System.IO;
namespace Lesson5_task01
{
    // запись введенного текста в файл
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для записи в файл.");
            string input = Console.ReadLine();
            string workDir=@"c:\!test\";
            WhriteInFile(input, "fileout.txt", workDir);
        }



        static void WhriteInFile(string inText, string fileName, string workDir)
        {
            string pathFile = Path.Combine(workDir, fileName);//создаем путь к файлу
            File.WriteAllText(pathFile, inText);// пишем текст в файл

        }
    }





}

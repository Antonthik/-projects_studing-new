using System;
using System.IO;
namespace Lesson5_task02
{
    //Программа добавления данных в файл
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            string workDir = @"c:\!test\";

            WhriteAddInFile(today.ToString(), "startup.txt", workDir);
        }

        static void WhriteAddInFile(string inText, string fileName, string workDir)
        {
            string pathFile = Path.Combine(workDir, fileName);//создаем путь к файлу
            File.AppendAllText(pathFile, $"{inText} {(char)13}");// пишем текст в файл


        }
    }
}

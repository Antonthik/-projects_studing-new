using System;
using System.IO;

namespace Lesson5_task03
{
    class Program
    {
        // запись введенного текста в ,бинарный файл
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ряд чисел от 1 до 255");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            byte[] arrBite = new byte[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrBite[i] = Convert.ToByte(arr[i]);
            }

            string workDir = @"c:\!test\";
            WhriteInFile(arrBite, "fileoutbyte.txt", workDir);
        }

        static void WhriteInFile(byte[] arr, string fileName, string workDir)
        {
            string pathFile = Path.Combine(workDir, fileName);//создаем путь к файлу
            File.WriteAllBytes(pathFile, arr);// пишем текст в файл

        }
    }
}

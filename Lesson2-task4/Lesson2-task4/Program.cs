using System;

namespace Lesson2_task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string org = "ИП ФРОЛОВА Ю.В.";//Переменная организация
            decimal sum = 3890.0m;//Переменная сумма
            decimal sumNoNDS = 3890.0m;//Переменная сумма без ндс
            string adr = "Москва, Луганская 5";//Переменная адрес
            DateTime dateOper = Convert.ToDateTime("05.12.17 11:35");//Переменная дата операции
            String inn = "504902878348";//Переменная инн
            string pn = "0001564232063737";//Переменная рн
            string fd = "139";//Переменная фд
            string fp = "2367137777";//Переменная фп


            //Формируем чек

            Console.WriteLine($"----------- {org} ------------");
            Console.WriteLine($"------------- {"кассовый чек"} -------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"---------------------------------------- ");
            Console.WriteLine($"Приход                          {sum}");
            Console.WriteLine($"---------------------------------------- ");
            Console.WriteLine($"ИТОГ                            {sum}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Наличными                       {sum}");
            Console.WriteLine($"Сумма без НДС                   {sumNoNDS}");
            Console.WriteLine($"{adr}");
            Console.WriteLine($"{dateOper.ToString("dd.MM.yyyy hh:mm")}");
            Console.WriteLine($"ИНН                       {inn}");
            Console.WriteLine($"РН                    {pn}");
            Console.WriteLine($"ФД                                 {fd}");
            Console.WriteLine($"ФП                          {fp}");
        }
    }
}

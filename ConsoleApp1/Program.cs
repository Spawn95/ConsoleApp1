using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите максимальную температуру за сутки");
            string max = Console.ReadLine();
            int x = Convert.ToInt32(max);
            Console.WriteLine("Укажите минимальную температуру за сутки");
            string min = Console.ReadLine();
            int y = Convert.ToInt32(min);
            int z = (x + y) / 2;// Средняя температура
            Console.WriteLine("Среднесуточная температура равна " + z);
            Console.WriteLine("Введите порядковый номер одного из месяцев");
            string q = Console.ReadLine();
            switch (q)
            {
                case "1":
                    Console.WriteLine("Январь");
                    break;
                case "2":
                    Console.WriteLine("Февраль");
                    break;
                case "3":
                    Console.WriteLine("Март");
                    break;
                case "4":
                    Console.WriteLine("Апрель");
                    break;
                case "5":
                    Console.WriteLine("Май");
                    break;
                case "6":
                    Console.WriteLine("Июнь");
                    break;
                case "7":
                    Console.WriteLine("Июль");
                    break;
                case "8":
                    Console.WriteLine("Август");
                    break;
                case "9":
                    Console.WriteLine("Сентябрь");
                    break;
                case "10":
                    Console.WriteLine("Октябрь");
                    break;
                case "11":
                    Console.WriteLine("Ноябрь");
                    break;
                case "12":
                    Console.WriteLine("Декабрь");
                    break;
            } 
            /*
            if (z > 0 , q = 12 , q = 1 , q = 2)  Никак не могу понять, в чем здесь ошибка или чего не хватает....
            {
                Console.WriteLine("Дождливя зима");
            } */
            int w = Convert.ToInt32(q);
            if (w % 2 == 0)
            {
                Console.WriteLine("Число и месяц четные");
            }
            else
            {
                Console.WriteLine("Число и месяц нечетные");
            }
        }
    }
}
            
        
    


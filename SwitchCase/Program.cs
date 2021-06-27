using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;    
                default:
                    Console.WriteLine("Yanlış veri girişi");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayı");
                    break;
                case 8:
                case 7:
                case 6:
                    Console.WriteLine("Yaz ayındasınız");
                    break;


                default:
                break;
            }
        }
    }
}

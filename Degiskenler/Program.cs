 using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;
            str1 = "Ulaş Osmanağaoğlu";
            string ad = "Ulaş";
            string soyad = "osmanagaoglu"
            string tamIsim = ad + " " + soyad;
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;
            bool bool1 = 10>2; // True
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);
            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2= DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);
            string datetime3 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);
        }
    }
}

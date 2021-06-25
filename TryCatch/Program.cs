using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi: "+ sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Hata ile karşılaşıldı.");
            }

            // try
            // {
            //     int a = int.Parse(null);
            // }
            // catch (ArgumentException ex)
            // {
            //     Console.WriteLine("**Boş Değer**");
            //     Console.WriteLine(ex);                
            // }
            try
            {
                int a = int.Parse("Test");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("**veri tipi uygun değil**");
                Console.WriteLine(ex);                
            }
            
        }
    }
}

using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bir sayı girin:");
            // int sayac = int.Parse(Console.ReadLine());
            // for (int i = 0; i < sayac; i++)
            // {
            //     if(i % 2 == 1)
            //         Console.WriteLine(i);
            // }
            // //1 ile 100 arasındaki tek ve çift sayıların toplamı
            // int tektoplam = 0;
            // int ciftoplam = 0;
            // for (int i = 1; i<= 100; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         tektoplam += i;
            //     }
            //     else{
            //         ciftoplam += i;
            //     }
            // }
            // Console.WriteLine("Çift Toplam: "+ciftoplam);
            // Console.WriteLine("Tek Toplam: "+tektoplam);

            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}

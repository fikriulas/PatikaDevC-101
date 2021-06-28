using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanımlama
            string[] renkler =  new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Balina"};
            int[] dizi;
            dizi = new int[5];
            //değer atama ve erişim;
            renkler[0] = "mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            Console.Write("Elaman sayısı girin: ");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[uzunluk];
            int toplam = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write((i+1)+".Elemanı girin: ");
                sayiDizisi[i] = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("Oluşturduğunuz dizi: ");
            foreach (var item in sayiDizisi)
            {
                toplam += item;
                Console.Write(item);
            }
            Console.WriteLine("\nOrtalama: "+ (toplam/uzunluk));
        }
    }
}

using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            int counter = 1;
            while (counter <= sayi)
            {
                toplam += counter;
                counter++;
            }
            Console.WriteLine("Ortalama: "+(toplam/sayi));

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }
            string[] arabalar = {"BMW","Ford","Toyata","Nissan"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }

        }
    }
}

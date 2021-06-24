﻿using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion -- bilincsiz donusum
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;  // int'in kapasitesi byte, sbyte shorttan fazla olduğunda dönüşüm gerekmedi.
            Console.WriteLine("d: "+d);

            string e = "ulaş";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g: "+g);
            //Explicit conversion -- bilinci donusum
            Console.WriteLine("**********Explicit Converion********");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);
            
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine(v);
            //to string
            int xx =6;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: "+zz);

            //system.convert
            string s1 = "10", s2 = "20";
            int sayi1,sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            //parse
            Parsemethod();
        }
        public static void Parsemethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);            
            double1 = Double.Parse(metin2);


        }
    }
}

﻿using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=3;
            int y = 4;
            y = y+2;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /=1;
            x *=2;

            Console.WriteLine(y);
            Console.WriteLine(x);
            //mantıksal operatörler
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");
            //ilişkisel operatorler
            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<b;
            Console.WriteLine(sonuc);

            //arimatik operatorler
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+ sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 ++;
            Console.WriteLine(sonuc1);



        }
    }
}
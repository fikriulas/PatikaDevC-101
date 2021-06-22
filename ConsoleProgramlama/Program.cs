using System;

namespace ConsoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("isim:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisim");
            string surname = Console.ReadLine();
            Console.WriteLine("Selam, "+name+" "+surname);
        }
    }
}

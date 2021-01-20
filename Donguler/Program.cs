using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] kurslar= new string[] { "kurs1","kurs2","kurs3","kurs4"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayda Sonu");
        }
    }
}

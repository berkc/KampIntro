using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Berk", "Berk1", "Berk2", "Berk3" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //List<string> isimler2 = new List<string> { "Berk","Berk1","Berk2","Berk3"};

            List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Berk4");
            Console.WriteLine(isimler2[4]);

        }
    }
}

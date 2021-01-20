using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşitir Butonu");
            }

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Product product1 = new Product();
            product1.Adi = "ELma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya ELması";
            

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Dİyarbakır Karpuzu";
            

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("-----------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,8);
        }
    }
}

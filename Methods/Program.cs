using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Detail = "Amasya Elması";


            Product product2 = new Product();

            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Detail = "Diyarbakır";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı : " + product.Name);
                Console.WriteLine("Ürün Fiyatı : " + product.Price);
                Console.WriteLine("Ürün Açıklaması : " + product.Detail);
                Console.WriteLine("-----------------------------\n");
            }

            Console.WriteLine("------------------Metotlar----------");

            BasketManager basketManager = new BasketManager();

            foreach (Product product in products)
            {
                basketManager.Add(product);
            }

            //basketManager.Add2("Armut",12,"Yeşil Armut");
            


        }
    }
}

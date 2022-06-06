using System;

namespace _6_iyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("1.Product elave et");
                Console.WriteLine("2.Product Sat");
                Console.WriteLine("3.Productlara bax");
                Console.WriteLine("4.Umumi satisi gostert");
                Console.WriteLine("5. Menyudan cix");

                option = int.Parse(Console.ReadLine());
                Market SunStore = new Market();

                switch (option)
                {
                    case 1:
                        Product product1 = new Product();
                        Console.Write("Mehsulun adini daxil edin:");
                       product1.Name= Console.ReadLine();
                        Console.Write("Mehsulun qiymetini daxil edin:");
                        product1.Price = int.Parse(Console.ReadLine());
                        Console.Write("Mehsulun nomresini daxil edin:");
                        product1.No=  Console.ReadLine();
                        Console.WriteLine("Mehsulunu sayini daxil edin");
                        product1.count = int.Parse(Console.ReadLine());
                        SunStore.AddProduct(product1);
                        break;
                    case 2:
                        Console.WriteLine("Mehsulun nomresini daxil edin");
                        SunStore.SellProduct(Console.ReadLine());
                        break;

                    case 3:
                        SunStore.ShowProduct();
                        break;

                    case 4:
                        Console.WriteLine("Good bye");
                        break;
                };




            } while (option != 4);
        }
    }
}

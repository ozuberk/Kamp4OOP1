using System;

namespace Kamp4OOP1
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {
           Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa"; 
            product1.UnitPrice = 45;
            product1.UnitsInStock = 25;

            // ya da şöyle yapabiliriz

            //Product product = new Product { Id = 1, CategoryId = 2, ProductName = "Masa", UnitPrice = 45, UnitsInStock = 25 };

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 3;
            product2.ProductName = "Sandalye";
            product2.UnitPrice = 35;
            product2.UnitsInStock = 25;

            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
            //Console.WriteLine(product1.ProductName);
            productManager.Update(product2);

            //productManager.Topla(2, 5);

            //int toplamaSonucu = productManager.Topla2(3, 5);
            //Console.WriteLine(toplamaSonucu);




            


          


        }
    }
}
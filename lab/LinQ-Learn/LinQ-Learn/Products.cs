using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Learn
{
    internal class Products
    {
        public static List<Product> products;

        static Products()
        {
            products = new List<Product>()
            {
                new Product(1, "Ban",200, new string[] {"Trang", "Xanh"},1),
                new Product(2, "tui",300, new string[] {"Do", "Den", "Vang"},2),
                new Product(3, "Ban tra",400, new string[] {"Xam", "Xanh"},2),
                new Product(4, "Tranh treo", 400, new string[] {"Vang", "Xanh"},1),
                new Product(5, "Den",500, new string[] {"Trang"},3),
                new Product(6, "Giuong", 500, new string[] {"Trang"},2),
                new Product(7, "Tu",600, new string[] {"Trang"},3),
            };
        }

        public static void ProductPrice500()
        {
            var products = Products.products;
            var ketqua = from product in products
                         where product.Price == 500
                         select product;

            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
        }
    }
}

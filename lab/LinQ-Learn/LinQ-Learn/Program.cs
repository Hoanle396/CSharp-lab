using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Learn
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Products.ProductPrice500();
                

                var products =  Products.products;
                var brands   =  Brand.brands; 


                // truy vấn cơ bản
                var ketqua = from product in products
                    where product.Price == 400
                    select product;
                Console.WriteLine("cac san pham co gia 400:");
                foreach (var product in ketqua)
                    Console.WriteLine(product.ToString());
                Console.WriteLine();    



                // tạo đối tượng vô danh kết quả trả về
                var ketqua1 = from product in products
                            where product.Price == 400 
                            select new {
                                ten = product.Name,
                                mausac = string.Join(',', product.Colors)
                            };
                Console.WriteLine("Ten, mau san pham co gia 400");
                foreach (var item in ketqua1) Console.WriteLine(item.ten + " - " + item.mausac);
                Console.WriteLine();    



                // lọc dữ liệu bằng where
                var ketqua2 = from product in products
                    where product.Price >= 500
                    where product.Name.StartsWith("Giuong")
                    select product;
                Console.WriteLine("San pham co ten bat dau la Giuong, gia tren 500");
                foreach (var product in ketqua2)
                    Console.WriteLine(product.ToString());
                Console.WriteLine();    


                //sử dụng from kết hợp để lọc
                var ketqua3 = from product in products
                              from color in product.Colors
                                where product.Price < 500
                                where color == "Vang"
                                select product;
                Console.WriteLine("San pham co mau vang , gia duoi 500");
                foreach (var product in ketqua3) Console.WriteLine(product.ToString());
                Console.WriteLine();    


                // Sắp xếp bằng orderby
                var ketqua4 = from product in products
                            where product.Price <= 300
                            orderby product.Price descending
                            select product;

                Console.WriteLine("San pham có gia duoi 300 sap xep theo gia nho dan");
                foreach (var product in ketqua4) Console.WriteLine($"{product.Name} - {product.Price}");
                Console.WriteLine(); 

                // Nhóm kết quả bằng group
                var ketqua5 = from product in products
                where product.Price >=400 && product.Price <= 500
                group product by product.Price;

                Console.WriteLine("Cac san pham theo nhom gia 400, 500");
                foreach (var group in ketqua5)
                {
                    Console.WriteLine(group.Key);
                    foreach (var product in group)
                    {
                        Console.WriteLine($"    {product.Name} - {product.Price}");
                    }

                }
                Console.WriteLine(); 

                // dùng biến trong truy vấn
                var ketqua6 = from product in products
                group product by product.Price into gr
                let count = gr.Count()
                select new {
                    price = gr.Key,
                    number_product = count
                };
                Console.WriteLine("Cac san pham theo gia");
                foreach (var item in ketqua6)
                {
                    Console.WriteLine($"   Giá {item.price} - có {item.number_product} sp");
                } 
                Console.WriteLine();


                // inner join
                var ketqua7 = from product in products
                            join brand in brands on product.Brand equals brand.ID
                            select new {
                                name  = product.Name,
                                brand = brand.Name,
                                price = product.Price
                            };

                Console.WriteLine("San pham- gia- ten hang");
                foreach (var item in ketqua7)
                {
                    Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
                }
                Console.WriteLine();


                // left join
                var ketqua8 = from product in products
                            join brand in brands on product.Brand equals brand.ID into t
                            from brand in t.DefaultIfEmpty()
                            select new {
                                name  = product.Name,
                                brand = (brand == null) ? "NO-BRAND" : brand.Name,
                                price = product.Price
                            };
                Console.WriteLine("San pham- gia -ten hang");
                foreach (var item in ketqua8)
                {
                    Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
                }
               
            
        }
    }
}

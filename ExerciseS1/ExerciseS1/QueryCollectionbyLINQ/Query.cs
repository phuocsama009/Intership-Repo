using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseS1.QueryCollectionbyLINQ
{
    class Query
    {
        // In ra các sản phẩm có giá bé hơn 900
        public void ProductPriceSmaller900(List<Product> products)
        {
            var result = from product in products
                         where product.Price < 900
                         select product;

            foreach (var product in result)
            {
                product.Display();
            }
        }

        // Lọc sản phẩm theo màu sắc và giá tiền
        public void ProductColorPrice(List<Product> products)
        {
            var result = from product in products
                         from color in product.Colors
                         where product.Price < 500
                         where color == "Vàng"
                         select product;

            foreach (var product in result)
            {
                product.Display();
            }
        }

        // Sắp xếp theo giá tiền
        public void OrderByPrice(List<Product> products)
        {
            var result = from product in products
                         orderby product.Price descending
                         select product;

            foreach (var product in result)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }
        }

        // Nhóm sản phẩm theo giá tiền
        public void GroupByPrice(List<Product> products)
        {
            var result = from product in products
                         where product.Price >= 400 && product.Price <= 500
                         group product by product.Price;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine($"\t{product.Name} - {product.Price}");
                }
            }
        }

        // Tìm sản phẩm theo nhãn hiệu
        public void ProductByBrand(List<Product> products, List<Brand> brands)
        {
            var result = from product in products
                         join brand in brands
                         on product.IdBrand equals brand.ID
                         select new
                         {
                             name = product.Name,
                             brand = brand.Name,
                             price = product.Price
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
            }
        }
    }
}

using AsyncTaskLibrary;
using FourOOPConceptsLibrary;
using QueryCollectionbyLINQLibrary;
using System;
using System.Collections.Generic;

namespace ExerciseS1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Async task
            Sample1 sample1 = new Sample1();
            sample1.Method1();
            sample1.Method2();
            #endregion

            #region Query Collection by LINQ
            var brands = new List<Brand>()
            {
                new Brand(1, "Công ty AAA"),
                new Brand(2, "Công ty BBB"),
                new Brand(3, "Công ty CCC"),
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   1000, new string[] {"Trắng"},              3),
                new Product(4, "Bàn học",    500, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            Query query = new Query();
            query.ProductPriceSmaller900(products);
            query.ProductColorPrice(products);
            query.OrderByPrice(products);
            query.GroupByPrice(products);
            query.ProductByBrand(products, brands);

            Console.WriteLine();
            #endregion

            #region Four OOP Concepts
            Officer officer = new Officer("Nguyen Van Teo", new DateTime(2000, 07, 07), 6);
            Staff staff = new Staff("Nguyen Thanh Truc", new DateTime(2001, 09, 09), "Part time", 28);

            officer.Display();
            Console.WriteLine();
            staff.Display();
            #endregion
        }
    }
}

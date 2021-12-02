using System;

namespace QueryCollectionbyLINQLibrary
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int IdBrand { get; set; }

        public Product(int id, string name, double price, string[] colors, int idBrand)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Colors = colors;
            this.IdBrand = idBrand;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Price: " + this.Price);
            Console.Write("Color: ");
            foreach (string color in Colors)
            {
                Console.Write(color + " ");
            }
            Console.WriteLine();
            Console.WriteLine("ID Brand: " + this.IdBrand);
            Console.WriteLine();
        }
    }
}

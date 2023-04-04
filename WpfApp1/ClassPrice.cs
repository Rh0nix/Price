using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Price
    {
        private string productName;
        private string storeName;
        private double price;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }
        public double Price1
        {
            get { return price; }
            set { price = value; }
        }
        public Price()
        {
            productName = "";
            storeName = "";
            price = 0;
        }
        public Price(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }
        public void Input()
        {
            Console.Write("Введите название товара: ");
            productName = Console.ReadLine();
            Console.Write("Введите название магазина: ");
            storeName = Console.ReadLine();
            Console.Write("Введите цену товара: ");
            price = double.Parse(Console.ReadLine());
        }
        public void  Output()
        {
            Console.WriteLine("Название товара: {0}", productName);
            Console.WriteLine("Название магазина: {0}", storeName);
            Console.WriteLine("Цена товара: {0}", price);
        }
        public void SaveToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(productName);
                sw.WriteLine(storeName);
                sw.WriteLine(price);
            }
        }
        public void LoadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                productName = sr.ReadLine();
                storeName = sr.ReadLine();
                price = double.Parse(sr.ReadLine());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Price price1 = new Price();
            price1.Input();
            price1.Output();
            price1.SaveToFile("price.txt");
            Price price2 = new Price("Хлеб", "Ашан", 45.99);
            price2.Output();
            price2.LoadFromFile("price.txt");
            price2.Output();
            Console.ReadKey();
        }
    }
}



using System;

namespace T2008m.labs1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product();
            product.id = 0;
            product.name = "dao minh giang"; 
            product.price = 150.000;
            product.qty = 1;
            product.image = "anh 1";
            product.desc = "ggwp";
            product.gallery.Add("anh1");
            product.gallery.Add("anh2");
            product.GetInfo();
            Console.WriteLine((product.CheckQty(product.qty))?"con hang":"het hang");
            Console.WriteLine("Nhap ten anh muon them:");
            var a=Console.ReadLine();
            product.AddImage(a);
        }

    }
}
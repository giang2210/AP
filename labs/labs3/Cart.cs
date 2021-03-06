using System;
using System.Collections.Generic;
using T2008m.lab.labs1;

namespace T2008m.lab.labs3
{
    public class Cart
    {
        public int id;
        public string customer,city,country;

        public delegate void CheckThemSP();

        public event CheckThemSP EventThemSP;

        public Cart()
        {
            if (EventThemSP==null)
            {
                EventThemSP += UpdateSP;
            }
        }
        
        public void UpdateSP()
        {
            Console.WriteLine("Event: Them Sp Thanh Cong.");
        }

        public double grandTotal=0;
        private List<Product> productList = new List<Product>();

        public void AddProduct(Product product)
        {
            productList.Add(product);
            EventThemSP();
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Danh sach cac san pham:");
            foreach (var VARIABLE in productList)
            {
                Console.WriteLine(VARIABLE.name);
            }
            Console.Write("Ban muon xoa san pham so:");
            var del = Convert.ToInt32(Console.ReadLine());
            productList.RemoveAt(del);
        }

        public void GrandTotal()
        {
            double Phiship = 0;
            Console.WriteLine("Danh sach cac san pham:");
            foreach (var VARIABLE in productList)
            {
                Console.WriteLine(VARIABLE.name );
                grandTotal += VARIABLE.price;
            }
            if (this.country=="VietNam")
            {
                if (this.city == "HN" || this.city == "HCM")
                {
                    Phiship = 0.01;
                    grandTotal += (grandTotal * Phiship);
                    Console.WriteLine("Tong tien la :"+grandTotal);
                    return ;
                }
                else
                {
                    Phiship = 0.02;
                    grandTotal += (grandTotal * Phiship);
                    Console.WriteLine("Tong tien la :"+grandTotal);
                    return;
                }
            }
            Phiship = 0.05;
            grandTotal += (grandTotal * Phiship);
            Console.WriteLine("Tong tien la :"+grandTotal);
        }
    }
}
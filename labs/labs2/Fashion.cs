using System;
using T2008m.lab.labs1;

namespace T2008m.lab.labs2
{
    public class Fashion : Product
    {
        public string mausac;
        public string kichco;
        public override bool CheckQty(int qty)
        {
            var rs= base.CheckQty(qty);
            if (rs)
            {
                Console.WriteLine("Trong kho con mau :"+this.mausac+" va size :"+this.kichco);
                return rs;
            }

            return rs;
        }
    }
}
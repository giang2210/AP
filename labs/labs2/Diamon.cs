using System;
using T2008m.lab.labs1;

namespace T2008m.lab.labs2
{
    public class Diamon : Product
    {
        public int cara;
        public override bool CheckQty(int qty)
        {
            var rs= base.CheckQty(qty);
            Console.WriteLine(rs?"Hang that":"Hang gia");
            return rs;
        }
    }
}
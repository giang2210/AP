using System;

namespace T2008m
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");
            Console.WriteLine("Nhap mot chuoi");
            string s = Console.ReadLine();
            Console.WriteLine("s = " + s);
            Console.WriteLine("Nhap vao mot so nguyen");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                n = 0;
            }

            Console.WriteLine("so vua nhap" + n);
            if (CheckPrime(n))
            {
                Console.WriteLine(n + "n la so nguyen to");
            }
        }

        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0) return false;
                
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;

namespace T2008m.lab.labs4
{
    public class Program
    {
        public static void Main(string[] args){ 
            List<KhachHangVN> danhsachVN = new List<KhachHangVN>();
            KhachHangVN khVietNam = new KhachHangVN();
            khVietNam.NhapXuat();
            danhsachVN.Add(khVietNam);
            khVietNam.HoaDon();
            KhachHangVN khVietNam1 = new KhachHangVN();
            khVietNam1.NhapXuat();
            danhsachVN.Add(khVietNam1);
            khVietNam1.HoaDon();
            //Tong so luong viet nam
            int tongSoLuongVn = 0;
            foreach (var VARIABLE in danhsachVN)
            {
                tongSoLuongVn += VARIABLE.SoLuong1;
            }
            Console.WriteLine("Tong so luong cua khach hang Viet Nam la: "+tongSoLuongVn);
            
            //Nuoc ngoai
            List<KhachHangNN> danhsachNN = new List<KhachHangNN>();
            KhachHangNN khNuocNgoai = new KhachHangNN();
            khNuocNgoai.NhapXuat();
            danhsachNN.Add(khNuocNgoai);
            khNuocNgoai.HoaDon();
            KhachHangNN khNuocNgoai1 = new KhachHangNN();
            khNuocNgoai1.NhapXuat();
            danhsachNN.Add(khNuocNgoai1);
            khNuocNgoai1.HoaDon();
            //Tong so luong nuoc ngoai
            int tongSoLuongNN = 0;
            foreach (var VARIABLE in danhsachNN)
            {
                tongSoLuongNN += VARIABLE.SoLuong1;
            }
            Console.WriteLine("Tong so luong cua khach hang Nuoc Ngoai la: "+tongSoLuongNN);
        }
    }
}
using System;

namespace T2008m.lab.labs4
{
    public abstract class KhachHang
    {
        public string MaKh,HoTen,NRHoaDon,DonGia;
        public int SoLuong;
        public string MaKh1
        {
            get => MaKh;
            set => MaKh = value;
        }

        public string HoTen1
        {
            get => HoTen;
            set => HoTen = value;
        }

        public string NRHoaDon1
        {
            get => NRHoaDon;
            set => NRHoaDon = value;
        }

        public int SoLuong1
        {
            get => SoLuong;
            set => SoLuong = value;
        }

        public string DonGia1
        {
            get => DonGia;
            set => DonGia = value;
        }

        public abstract void NhapXuat();
        public abstract void HoaDon();

    }

}
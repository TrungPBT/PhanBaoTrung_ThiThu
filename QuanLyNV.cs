using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_ThiThu
{
    internal class QuanLyNV
    {
        string ten;
        string maNV;
        string chucVu;
        double luongCB;

        public string Ten { get => ten; set => ten = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double LuongCB { get => luongCB; set => luongCB = value; }
        public QuanLyNV() { }  
        public QuanLyNV(string ten, string maNV, string chucVu, double luongCB)
        {
            Ten = ten;
            MaNV = maNV;
            ChucVu = chucVu;
            LuongCB = luongCB;
        }
    }
}

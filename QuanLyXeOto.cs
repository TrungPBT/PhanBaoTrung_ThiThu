using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_ThiThu
{
    internal class QuanLyXeOto
    {
        string hangXe;
        string bienSo;
        string namSanXuat;
        double giaBan;

        public string HangXe { get => hangXe; set => hangXe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public string NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public QuanLyXeOto() { }
        public QuanLyXeOto(string hangXe, string bienSo, string namSanXuat, double giaBan)
        {
            this.HangXe = hangXe;
            this.BienSo = bienSo;
            this.NamSanXuat = namSanXuat;
            this.GiaBan = giaBan;
        }
    }
   
}

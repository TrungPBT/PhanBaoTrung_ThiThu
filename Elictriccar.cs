using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_ThiThu
{
    internal class Elictriccar : QuanLyXeOto
    {
        int batteryCapacity;

        public int BatteryCapacity { get => batteryCapacity; set => batteryCapacity = value; }
        public Elictriccar() { }
        public Elictriccar(string hangXe, String bienSo, String namSanXuat, double giaBan, int batteryCapacity)
        {
            this.BatteryCapacity = batteryCapacity;
        }
    }
    
}

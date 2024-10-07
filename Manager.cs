using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_ThiThu
{
    internal class Manager : QuanLyNV
    {
        string teamsize;

        public string Teamsize { get => teamsize; set => teamsize = value; }
        public Manager() { }
        public Manager(string teamsize)
        {
            Teamsize = teamsize;
        }
    }
}

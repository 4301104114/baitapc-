using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Nhanvien
    {
        protected string maNhanVien;
        protected string tenNhanVien;
        protected double tienPhuCap;
        public abstract double tienLuong 
        {
            get;
        }
        public Nhanvien() 
        {
            maNhanVien = "xxxxxx";
            tenNhanVien = "No Name";
            tienPhuCap = 0.0;
        }
        public Nhanvien(string _maNhanVien, string _tenNhanVien, double _tienPhuCap) 
        {
            maNhanVien = _maNhanVien;
            tenNhanVien = _tenNhanVien;
            tienPhuCap = _tienPhuCap;
        }
    }
}

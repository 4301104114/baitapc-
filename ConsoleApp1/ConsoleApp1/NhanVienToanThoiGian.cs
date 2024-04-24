using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NhanVienToanThoiGian: Nhanvien
    {
        private double hesoLuong;
        public override double tienLuong => hesoLuong * 1200000;
        public NhanVienToanThoiGian():base() 
        {
            hesoLuong = 0.0;
        }
        public NhanVienToanThoiGian(string _maNhanVien, string _tenNhanVien, double _tienLuong, double _hesoLuong)
        :base(_maNhanVien, _tenNhanVien, _tienLuong)
        {
            hesoLuong = _hesoLuong;
        }
        public void nhapThongTinNhanVienToanThoiGian() 
        {
            Console.WriteLine("Nhap ma cua nhan vien");
            maNhanVien = Console.ReadLine();

            Console.WriteLine("Nhap ten day du cua nhan vien");
            tenNhanVien = Console.ReadLine();

            Console.WriteLine("Nhap tien phu cap cua nhan vien");
            tienPhuCap = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap he so luong cua nhan vien");
            hesoLuong = double.Parse(Console.ReadLine());
        }
        public void xuatThongTinNhanVienToanThoiGian() 
        {
            Console.WriteLine($"Ma cua nhan vien: {maNhanVien}");
            Console.WriteLine($"Ten day du cua nhan vien: {tenNhanVien}");
            Console.WriteLine($"Tien phu cap cua nhan vien: {tienPhuCap}");
            Console.WriteLine($"Tien luong cua nhan vien: {tienLuong}");

        }
    }
}

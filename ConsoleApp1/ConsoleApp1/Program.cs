using System;
using System.Collections;

namespace ConsoleApp1
{
    
   internal class Program
   { 
        static void Main(string[] args)
        {

           NhanVienToanThoiGian nv = new NhanVienToanThoiGian();

           nv.nhapThongTinNhanVienToanThoiGian();  
           nv.xuatThongTinNhanVienToanThoiGian();

            Console.ReadKey();
        
        }
   }
}



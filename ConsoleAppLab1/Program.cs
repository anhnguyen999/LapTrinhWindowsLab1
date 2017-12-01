using System;
using ConsoleAppLab1.Model;
using System.Collections.Generic;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bat dau chuong trinh
            //Console.WriteLine("\tDEMO NHAP XUAT SINH VIEN");
            //Student student = new Student();
            //student.Input();
            //student.Show();
            Console.WriteLine("\tDEMO NHAP XUAT DANH SACH SINH VIEN");
            DanhSachSinhVien danhSachSinhVien = new DanhSachSinhVien();
            danhSachSinhVien.Nhap();
            danhSachSinhVien.Xuat();
            //Stop to monitor result
            Console.ReadLine();
        }
    }
}

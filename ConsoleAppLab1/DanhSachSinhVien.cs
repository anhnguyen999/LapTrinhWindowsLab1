using ConsoleAppLab1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    class DanhSachSinhVien
    {
        int soLuongSinhVien = -1;
        Student newStudent;
        List<Student> students = new List<Student>();
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap so luong sinh vien: ");
                try
                {
                    soLuongSinhVien = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Loi nhap lieu: {0}", ex.Message);
                }
            } while (soLuongSinhVien <= 0);
            //Nhap danh sach sinh vien
            for (int i = 0; i < soLuongSinhVien; i++)
            {
                Console.WriteLine("\t: Nhap sinh vien thu {0}", i);
                newStudent = new Student();
                newStudent.Input();
                students.Add(newStudent);
            }
        }
        public void Xuat()
        {
            //Hien thi danh sach sinh vien
            foreach (var st in students)
            {
                Console.WriteLine("-----------");
                st.Show();
            }
        }
    }
}

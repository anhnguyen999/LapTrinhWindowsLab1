using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1.Model
{
    class Student : People
    {
        public int Id { get; set; }
        
        //Constuctor 
        public Student(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }

        public Student()
        {

        }
        
        /// <summary>
        /// Nhap thong tin sinh vien
        /// </summary>
        public void Input()
        {
            Console.Write("Nhap Id: ");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap FullName: ");
            this.FullName = Console.ReadLine();
        }

        /// <summary>
        /// Hien thi thong tin sinh vien
        /// </summary>
        internal void Show()
        {
            Console.WriteLine("Id: {0}",this.Id);
            Console.WriteLine("FullName: {0}", this.FullName);
        }
    }
}

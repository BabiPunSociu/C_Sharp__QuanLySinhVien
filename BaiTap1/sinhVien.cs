using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class sinhVien
    {
        public string hoTen;
        public DateTime dateOfBirth;
        public double diemLapTrinh;
        public double diemCSDL;
        public double diemWeb;

        public sinhVien() { }

        public sinhVien(string hoTen, DateTime dob, double diemLT, double diemCSDL, double diemWeb)
        {
            this.hoTen = hoTen;
            this.dateOfBirth = dob;
            this.diemLapTrinh = diemLT;
            this.diemCSDL = diemCSDL;
            this.diemWeb = diemWeb;
        }

        public void nhapSinhVien()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine().Trim();

            // Nhập ngày sinh dạng dd/mm/yyyy
            Console.Write("\nNhap ngay sinh (dd/mm/yyyy) : ");
            string input = (Console.ReadLine()).Trim();
            string[] arrListStr = input.Split('/', ' ', '.', '-', '_');
            int ngay = int.Parse(arrListStr[0]);
            int thang = int.Parse(arrListStr[1]);
            int nam = int.Parse(arrListStr[2]);
            dateOfBirth = new DateTime(nam, thang, ngay);

            Console.Write("\nNhap diem mon lap trinh: ");
            diemLapTrinh = Convert.ToDouble(Console.ReadLine().Trim());
            Console.Write("\nNhap diem mon co so du lieu: ");
            diemCSDL = Convert.ToDouble(Console.ReadLine().Trim());
            Console.Write("\nNhap diem mon thiet ke web: ");
            diemWeb = Convert.ToDouble(Console.ReadLine().Trim());
        }

        public void Display()
        {
            Console.Write("\n{0,20}" + "|" + "{1,9}" + "|" + "{2,15}" + "|" + "{3,15}" + "|" + "{4,15}",
                hoTen, dateOfBirth.ToString("dd/MM/yyyy"), diemLapTrinh, diemCSDL, diemWeb);
        }
    }
}

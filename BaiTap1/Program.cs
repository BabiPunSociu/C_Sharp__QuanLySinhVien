using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    internal class Program
    {
        public static int soLuongKhoaLuan(List<sinhVien> svKhoaLuan, List<sinhVien> sinhViens)
        {
            int result = 0;
            foreach (sinhVien s in sinhViens)
            {
                if (s.diemLapTrinh >= 5.0 && s.diemCSDL >= 5 && s.diemWeb >= 5 && (s.diemLapTrinh + s.diemCSDL + s.diemWeb)/3 >= 8)
                {
                    result++;
                    svKhoaLuan.Add(s);
                }
            }
            return result;
        }

        public static int soLuongChuyenDe(List<sinhVien> svChuyenDe, List<sinhVien> sinhViens)
        {
            int result = 0;
            foreach (sinhVien s in sinhViens)
            {
                if (s.diemLapTrinh >= 5.0 && s.diemCSDL >= 5 && s.diemWeb >= 5 && (s.diemLapTrinh + s.diemCSDL + s.diemWeb)/3 < 8)
                {
                    result++;
                    svChuyenDe.Add(s);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhap so luong sinh vien: n = ");
                n = int.Parse(Console.ReadLine().Trim());
            } while (n <= 0);

            List<sinhVien> sinhViens = new List<sinhVien>();

            // Nhap ds sinh vien
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));

                sinhVien sv = new sinhVien();
                sv.nhapSinhVien();
                sinhViens.Add(sv);

                Console.WriteLine("------------------------------");
            }


            List<sinhVien> svKhoaLuan = new List<sinhVien>();   // Lưu các sv làm khóa luận tốt nghiệp

            Console.WriteLine("So luong sinh vien duoc lam khoa luan tot nghiep la: " + soLuongKhoaLuan(svKhoaLuan, sinhViens));
            Console.WriteLine("Danh sach sinh vien duoc lam khoa luan tot nghiep:");
            Console.Write("\n{0,20}" + "|" + "{1,9}" + "|" + "{2,15}" + "|" + "{3,15}" + "|" + "{4,15}",
                "Ho ten", "Ngay sinh", "Diem lap trinh", "Diem CSDL", "Diem Web");
            foreach (sinhVien s in svKhoaLuan)
            {
                s.Display();
            }


            List<sinhVien> svChuyenDe = new List<sinhVien>();   // Lưu các sv làm chuyên đề tốt nghiệp
            Console.WriteLine("\nSo luong sinh vien duoc lam chuyen de tot nghiep la: " + soLuongChuyenDe(svChuyenDe, sinhViens));
            Console.WriteLine("Danh sach sinh vien duoc lam chuyen de tot nghiep:");
            Console.Write("\n{0,-20}" + "|" + "{1,10}" + "|" + "{2,15}" + "|" + "{3,15}" + "|" + "{4,15}",
                "Ho ten", "Ngay sinh", "Diem lap trinh", "Diem CSDL", "Diem Web");
            foreach (sinhVien s in svChuyenDe)
            {
                s.Display();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct sinhvien
        {
            public string hoten160;
            public string msv160;
            public gioitinh gioitinh160;
            public double toan160;
            public double ly160;
            public double hoa160;

            
        };
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n160 = int.Parse(Console.ReadLine());
            sinhvien[] sv160 = new sinhvien[n160];
            nhapDS(ref sv160, n160);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv160, n160);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht160 = Console.ReadLine();
            timKiem(sv160, n160, ht160);

            Console.ReadLine();
        }

        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht160 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv160 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt160 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt160 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl160 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh160 = double.Parse(Console.ReadLine());


                sv[i].hoten160 = ht160;
                sv[i].msv160 = msv160;
                if (gt160 == 0)
                    sv[i].gioitinh160 = gioitinh.Nam;
                else
                    sv[i].gioitinh160 = gioitinh.Nu;
                sv[i].toan160 = dt160;
                sv[i].ly160 = dl160;
                sv[i].hoa160 = dh160;

            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach(sinhvien item160 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item160.hoten160);
                Console.WriteLine("Ma sinh vien: " + item160.msv160);
                int gt = (int)item160.gioitinh160;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item160.toan160);
                Console.WriteLine("Diem ly: " + item160.ly160);
                Console.WriteLine("Diem hoa: " + item160.hoa160);
                int hocluc = (int)diemTB(item160.toan160, item160.ly160, item160.hoa160);
                switch(hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach(sinhvien item160 in sv)
            {
                if(item160.hoten160 == ht)
                {
                    Console.WriteLine("Ho ten: " + item160.hoten160);
                    Console.WriteLine("Ma sinh vien: " + item160.msv160);
                    int gt = (int)item160.gioitinh160;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item160.toan160);
                    Console.WriteLine("Diem ly: " + item160.ly160);
                    Console.WriteLine("Diem hoa: " + item160.hoa160);
                    int hocluc = (int)diemTB(item160.toan160, item160.ly160, item160.hoa160);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
    }
}

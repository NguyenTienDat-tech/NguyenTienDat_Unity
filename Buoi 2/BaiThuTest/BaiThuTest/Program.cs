using System.Collections;
using System.Runtime.CompilerServices;

namespace BaiThuTest
{
    class Program
    {

        struct SinhVien
        {
            public string ten;
            public int tuoi;
            public double diemtk;

            public SinhVien(string ten, int tuoi, double diemtk)
            {
                this.ten = ten;
                this.tuoi = tuoi;
                this.diemtk = diemtk;
            }
        };
        

        static void Main(string[] args)
        {
            List<SinhVien> a = new List<SinhVien>();
            SinhVien sv = new SinhVien();
                a.Add(new SinhVien("Nguyen Tien Dat", 18, 9));
                a.Add(new SinhVien("Pham Van Muoi", 18, 4));
                a.Add(new SinhVien("Pham Van Dong", 19, 7));
                a.Add(new SinhVien("Bu Con Muoi", 20, 2));
                a.Add(new SinhVien("Luon Van Dong", 17, 5));


            Console.WriteLine("Danh sach: ");
            foreach(var item in a)
            {
                if (sv.diemtk > 5)
                {
                    Console.WriteLine(item);
                }
            }
                

        }

    }
}
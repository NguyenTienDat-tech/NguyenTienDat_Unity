namespace Bai4
{
    internal class Program
    {
        //hàm nhập chuỗi
        private static void nhapchuoi(out string nhap, out string tim, out string chen) //sử dụng từ khóa out để trả về nhiều giá trị cùng lúc
        {
            Console.Write("Nhap chuoi ban dau: ");
            nhap = Console.ReadLine();
            Console.Write("Nhap chuoi can tim: ");
            tim = Console.ReadLine();
            Console.Write("Nhap chuoi can chen: ");
            chen = Console.ReadLine();
        }

        private static void kiemTra(string nhap, string tim, string chen)
        {
            int vitri = nhap.IndexOf(tim); //tìm vị trí chuỗi cần tìm trong chuỗi ban đầu
            if (vitri != -1)
            {
                string ketqua = nhap.Insert(vitri, chen + " "); //chèn chuỗi cần chèn trước chuỗi cần tìm
                Console.WriteLine("Chuoi sau khi chen: " + ketqua);
            }
            else
            {
                Console.WriteLine("Chuoi can tim khong ton tai trong chuoi ban dau.");
            }
        }



        static void Main(string[] args)
        {
            string nhap, tim, chen;
            nhapchuoi(out nhap, out tim, out chen);
            kiemTra(nhap, tim, chen);

        }
    }

}
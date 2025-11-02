namespace Bai2
{
    public class Program
    {
        static string KiemTra(string nhap)
        {
            char[] a = nhap.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                        char temp = a[i];
                         a[i] = a[j];
                         a[j] = temp;
                }
            }
            string ketqua = new string(a); //chuyển mảng ký tự a trở lại thành chuỗi string
            return ketqua;
        }



        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string nhap = Console.ReadLine(); 
            Console.WriteLine(KiemTra(nhap));
        }
    }
}
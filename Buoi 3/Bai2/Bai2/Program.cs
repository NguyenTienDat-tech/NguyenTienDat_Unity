namespace Bai2
{
    public class Program
    {
        static string DaoNguoc(string chuoi)
        {
            char[] a = chuoi.ToCharArray();
            int i = 0;
            int j = a.Length - 1;

            while (i < j)
            {
                char temp = a[i];
                a[i] = a[j];
                a[j] = temp;

                i++;
                j--;
            }
            string ketqua = new string(a);
            return ketqua;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            Console.WriteLine("Chuoi sau khi dao nguoc: ");
            Console.WriteLine(DaoNguoc(chuoi));

        }
    }
}
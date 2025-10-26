namespace Bai3
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) // duyệt từng hàng
            {
                for (int j = 1; j <= n - i; j++) // cách 2 khoảng trắng
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++) //dãy tăng dần
                {
                    Console.Write(j + " ");
                }
                for (int j = i - 1; j >= 1; j--) // dãy giảm dần
                {
                    Console.Write(j + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}

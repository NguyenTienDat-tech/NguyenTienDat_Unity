namespace Bai1
{
    internal class Program
    {
        private static void nhap(out int a, out int b, out int c)
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
        }

        private static void TamGiac(int a, int b, int c)
        {
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Tam giac deu");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tam giac can");
            }
            else if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Tam giac thuong");
            }
            else
            {
                Console.WriteLine("Day khong phai la 3 canh cua tam giac");
            }
        }



        static void Main(string[] args)
        {
            int a, b, c;
            nhap(out a, out b, out c);
            TamGiac(a, b, c);

        }
    }
}
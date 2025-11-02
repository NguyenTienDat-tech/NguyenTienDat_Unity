namespace Bai3
{
    public class Program
    {
        struct Product
        {
            string Name; //tên sản phẩm
            float Price; //giá bán
            int Quantity; //số lượng bán được
            string Category; //danh mục

            public Product(string Name, float Price, int Quantity, string Category)
                {
                this.Name = Name;
                this.Price = Price;
                this.Quantity = Quantity;
                this.Category = Category;
                }

        }

        static void NhapThongTin(out string Name, out float Price, out int Quantity, out string Category)
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            Price = Console.Read();
            Console.ReadLine();
            Console.Write("Nhap so luong ban: ");
            Quantity = Console.Read();
            Console.Write("Nhap danh muc: ");
            Category = Console.ReadLine();
           

        }


        static void KiemTra()
        {
            Dictionary<string, Product> map = new Dictionary<string, Product>(); //string: mã sản phẩm, Product: thông tin sản phẩm
            {

            }
        }



        static void Main()
        {
            string Name;
            float Price;
            int Quantity;
            string Category;
            NhapThongTin(out Name, out Price, out Quantity, out Category);
        }
    }
}

namespace Bai1
{
    class Program
    {
        static string KiemTra(string a)
        {
            Stack<char> stack = new Stack<char>(); // Khai báo stack để lưu trữ dấu ngoặc(ngăn xếp)
            Dictionary<char, char> map = new Dictionary<char, char>() // kiểm tra xem dấu ngoặc mở và đóng có khớp nhau không
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach(char c in a) //lấy từng ký tự trong c và kiểm tra xem ký tự đó đã đóng tương ứng hay chưa
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0 || stack.Peek() != map[c])  //stack.Peek: Lấy phần tử trên cùng của stack
                    {
                        return "No";
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0 ? "Yes" : "No"; //Nếu stack rỗng --> yes, nếu còn dư --> no
        }


        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi chua dau ngoac: ");
            string a = Console.ReadLine();

            Console.WriteLine(KiemTra(a));
        }
    }
}

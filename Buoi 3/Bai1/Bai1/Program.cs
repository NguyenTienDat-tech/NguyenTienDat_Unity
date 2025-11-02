namespace Bai1
{
    public class Program
    {
        static string KiemTra(string chuoi)
        {
            Stack<char> stack = new Stack<char>(); //khai báo stack để lưu dấu ngoặc thành ngăn xếp
            Dictionary<char, char> dictionary = new Dictionary<char, char>() //kiểm tra xem dấu ngoặc mở và đóng có khớp với nhau không
            {
                {')', '(' },
                {'}', '{' },
                {']', '[' }
            };

            foreach (char ch in chuoi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != dictionary[ch]) // stack.Peek(): lấy phần tử trên cùng của stack để kiểm tra xem có khớp với ngoặc đóng không(dictionary[ch])
                    {
                        return "No";
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0 ? "Yes" : "No"; //nếu stack rỗng--> Yes, còn dư --> "No"
        }
        




        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi chua cac dau ngoac: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine(KiemTra(chuoi));
        }
    }

}

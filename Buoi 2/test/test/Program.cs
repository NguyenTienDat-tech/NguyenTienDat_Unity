using System.Collections;
using System.Reflection.Metadata.Ecma335;

class Program
{
    
    public static void Main(string[] args)
    {
        //Ham Stack
        Stack<int> stack = new Stack<int>(); //lấy phần tử đầu trong dãy rồi lần lượt
        stack.Push(1);
        Console.WriteLine(stack.Pop());

        //Ham Dictionary
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(34, "Hai Duong");
        dic.Add(17, "Thai Binh");
        Console.WriteLine(dic[34]); 
        Console.WriteLine(dic.TryGetValue(34, out string s)); //tính đúng sai
        Console.WriteLine(s);

        //in ham enum
        Console.WriteLine((int)color.Red);

        //tham trị của struct
        Num num1 = new Num();
        num1.n = 1;
        Num num2 = new Num();
        num2 = num1;
        num2.n = 2;
        Console.WriteLine(num2.n);
    }

    enum color
    {
        Red = 0,
        Green = 1,
        Blue = 2,
    }

    struct Num()
    {
        public int n;
    }

}

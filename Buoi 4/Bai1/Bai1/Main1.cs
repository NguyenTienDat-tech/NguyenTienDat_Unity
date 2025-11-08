class Main1 
{
    List<CongNhan> danhsach = new List<CongNhan>();

    public void TimCN()
    {
        int Tim;
        Console.Write("Nhap ma cong nhan muon tim: ");
        Tim = int.Parse(Console.ReadLine());

        bool KiemTra = false;

        foreach (CongNhan i in danhsach)
        {
            if (i.MaCN == Tim)
            {
                i.InThongTin();
                KiemTra = true;
            }
        }
        if (!KiemTra) 
        {
            Console.WriteLine("Khong tim thay cong nhan nao!");
        }
    }


    public void Menu()
    {
        int n;
        do //Dùng do/while để chạy tiếp chương trình 
        {
            Console.WriteLine("========= MENU ===========");
            Console.WriteLine("1.Them cong nhan");
            Console.WriteLine("2.Hien thi danh sach");
            Console.WriteLine("3.Sap xep cong nhan theo ho ten");
            Console.WriteLine("4.Tim cong nhan theo ma");
            Console.WriteLine("5.Thoat");

            Console.WriteLine("Lua chon:");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Nhap so cong nhan muon them: ");
                    int them = int.Parse(Console.ReadLine());
                    for (int i = 0; i < them; i++)
                    {
                        CongNhan cn = new CongNhan(); //tạo mới mỗi lần nhập
                        cn.NhapThongTin();
                        danhsach.Add(cn);
                        Console.WriteLine("Da them cong nhan!");
                    }
                    break;
                case 2:
                    foreach (CongNhan i in danhsach)
                    {
                        Console.WriteLine("==========DANH SACH CONG NHAN===========");
                        i.InThongTin();
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    danhsach.Sort((a, b) => a.Ten.CompareTo(b.Ten)); //Dùng public Ten để lấy dữ liệu cho các lớp khác dùng được
                    Console.WriteLine("==========DANH SACH CONG NHAN SAP XEP THEO HO TEN===========");
                    foreach (CongNhan i in danhsach)
                    {
                        i.InThongTin();
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    Console.WriteLine("==========TIM CONG NHAN THEO MA===========");
                    TimCN();
                    break;
                default:
                    Console.WriteLine("Khong ton tai truong hop nay!");
                    break;
            }
        }
        while (n != 5); 
    }


    static void Main(string[] args)
    {
        Main1 m = new Main1();
        m.Menu();
    }
}


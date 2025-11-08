 //Em chưa hiểu cách viết hàm trùng mã và sắp xếp theo lương khi họ tên giống nhau hi vọng các a bỏ qua cho và giúp em vào buổi sau ạ



class CongNhan : Person
  {
    public int MaCN {  get; set; }

    public enum ChucVu
    {
        TruongNhom,
        PhoNhom,
        CongNhanBac3,
        CongNhanBac2,
        CongNhanBac1,
        Khac
    }


    public ChucVu ChucVuCongNhan { get; set; }

    public double TinhLuong()
    {
        double HeSoLuong = 1.0;

        if (ChucVuCongNhan == ChucVu.TruongNhom)
        {
            HeSoLuong = 3.0;
        }
        else if (ChucVuCongNhan == ChucVu.PhoNhom)
        {
            HeSoLuong = 2.5;
        }
        else if (ChucVuCongNhan == ChucVu.CongNhanBac3)
        {
            HeSoLuong = 2.0;
        }
        else if (ChucVuCongNhan == ChucVu.CongNhanBac2)
        {
            HeSoLuong = 1.5;
        }
        else if (ChucVuCongNhan == ChucVu.CongNhanBac1)
        {
            HeSoLuong = 1.2;
        }
        else
        {
            HeSoLuong = 1.0;
        }

        double Luong = HeSoLuong * 8000000;
        return Luong;
    }

    public void NhapThongTin()
    {
            Console.Write("Nhap ma cong nhan: ");
            MaCN = int.Parse(Console.ReadLine());
            AddCongNhan();
            Console.Write("Nhap chuc vu (TruongNhom, PhoNhom, CongNhanBac3, 2, 1): ");
            string chon = Console.ReadLine();

            //Chuyển string sang Enum
            if (Enum.TryParse(chon, true, out ChucVu cv))
            {
                ChucVuCongNhan = cv;
            }
            else
            {
                Console.WriteLine("Chuc vu khong ton tai");
                ChucVuCongNhan = ChucVu.Khac;
            }
    }
    
    public void InThongTin()
    {
        Console.Write("Ma cong nhan: " + MaCN);
        InCongNhan();
        Console.WriteLine(" || Chuc vu: " + ChucVuCongNhan + " || Luong: " + TinhLuong());
    }
  }


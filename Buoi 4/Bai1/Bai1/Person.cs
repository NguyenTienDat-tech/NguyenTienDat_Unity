class Person
{
    public string Ten { get; set; }
    private int Tuoi { get; set; }
    private string DiaChi { get; set; }

    public void AddCongNhan()
    {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine(); 
    }

    public void InCongNhan()
    {
        Console.Write(" || Ten: " + Ten + " || Tuoi: " + Tuoi + " || Dia chi: " + DiaChi);
    }
}
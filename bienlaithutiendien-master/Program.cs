// See https://aka.ms/new-console-template for more information
using System;

using tiendien;
public class progam
{
    static void Main(string[] args)

    {
        KhachHangVN a = new KhachHangVN(1, "Le Minh Duc", "2022-07-22", 219, "Cá nhân");
        KhachHangNN b = new KhachHangNN(2, "Nguyen Van An", "2022-09-21", 156, "US");
        Console.WriteLine(a.ThanhTien);
        Console.WriteLine(b.ThanhTienNN);

    }
}
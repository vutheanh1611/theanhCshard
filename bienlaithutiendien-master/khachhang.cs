using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendien
{
    public class KhachHang
    {
        public KhachHang()
        {

        }

        public KhachHang(int code, string fullName, string date, int quantity)
        {
            ID = code;
            FullName = fullName;
            Date = date;
            Quantity = quantity;
        }

        public int ID { get; set; }
        public string FullName { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }

        public virtual int ThanhTien()
        {
            return Quantity * 2000;
        }
    }

    public class KhachHangNN : KhachHang
    {
        public KhachHangNN()
        {

        }

        public KhachHangNN(int code, string fullname, string date, int quantity, string quoctich)
        {
            ID = base.ID;
            FullName = base.FullName;
            Date = base.Date;
            Quantity = base.Quantity;
            Quoctich = quoctich;
        }

        public string Quoctich { get; set; }

        public int ThanhTienNN()
        {
            return base.ThanhTien();
        }
    }

    public class KhachHangVN : KhachHang
    {
        public KhachHangVN()
        {

        }

        public KhachHangVN(int code, string fullname, string date, int quantity, string doituong)
        {
            ID = base.ID;
            FullName = base.FullName;
            Date = base.Date;
            Quantity = base.Quantity;
            Doituong = doituong;
        }

        public string Doituong { get; set; }

        public override int ThanhTien()
        {
            if (Quantity < 50)
                return Quantity * 1000;
            else if (Quantity < 100)
                return (Quantity - 50) * 1200 + 50 * 1000;
            else if (Quantity < 200)
                return (Quantity - 100) * 1500 + 50 * 1200 + 50 * 1000;
            else
                return (Quantity - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
        }
    }
}
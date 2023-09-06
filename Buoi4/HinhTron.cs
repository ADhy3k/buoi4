using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Buoi4
{
    class HinhTron
    {
        ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public HinhTron()
        {
            Tam.Ten = "A";
            Tam.X = 1;
            Tam.Y = 1;
        }
        public HinhTron(ToaDo a, double BK)
        {
            this.tam = a;
            this.BanKinh = BK;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ban kinh: ");
            banKinh = double.Parse(Console.ReadLine());
        }
        public double tinhCV()
        {
            return 2 * 3.14 * BanKinh;
        }
        public double tinhDT()
        {
            return 3.14 * BanKinh * BanKinh;
        }
    }
}

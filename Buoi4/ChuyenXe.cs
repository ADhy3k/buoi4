using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class ChuyenXe
    {
        private string maSC, hoTen, soXe;

        public string MaSC
        {
            get { return maSC; }
            set { maSC = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }
        private double doanhThu;

        public double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }
        public ChuyenXe()
        {
            MaSC = "A001";
            HoTen = "Nguyen Van A";
            SoXe = "AB12";
            DoanhThu = 300;
        }
        public ChuyenXe(string maSC, string hoTen, string soXe, double doanhThu)
        {
            this.MaSC = maSC;
            this.HoTen = hoTen;
            this.SoXe = soXe;
            this.DoanhThu = doanhThu;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Thong tin chuyen xe");
            Console.WriteLine("Ma so chuyen: ",maSC);
            Console.WriteLine("Ho ten tai xe: ",hoTen);
            Console.WriteLine("                                                                                                                                                         ");
        }
    }
}

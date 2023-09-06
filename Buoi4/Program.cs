using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo a = new ToaDo();
            a.Ten = "A";
            a.X = 5;
            a.Y = 6;
            HinhTron x = new HinhTron(a,2);
            Console.WriteLine("Hinh tron co tam {0} voi ban kinhX1} có dien tich và chu vi lan luot là {2} và {3}", x.Tam.ToString(), x.BanKinh, Math.Round(x.tinhDT(), 3), Math.Round(x.tinhCV(), 3));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class ToaDo
    {
        string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        float x, y;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public ToaDo()
        {
            Ten = "A";
            X = 1;
            Y = 1;
        }
        public ToaDo(string ten, float x, float y)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public virtual void nhap()
        {
            Console.WriteLine("Moi nhap ten toa do: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            y = float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return Ten + "(" + X + ", " + Y + ")";
        }
    }
}

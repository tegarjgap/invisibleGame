using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        //bikin constructor default -> kaya manggil fungsi biasa
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //ini buat ngitung jarak tembak
        public int jarakKe(int x, int y)
        {
            int selisihX = (X - x) * (X - x);
            int selisihY = (Y - y) * (Y - y);
            int hasil = (int)Math.Sqrt(selisihX + selisihY);

            return hasil;
        }

        //ini buat ngitung jarak tembak bikin fungsi baru
        public int jarakKe(Point p)
        {
            //manggil fungsi sendiri rekursif
            return jarakKe(p.X ,p.Y);
        }
    }
}

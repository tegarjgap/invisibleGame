using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Map
    {
        //buat set atribut kudu pke huruf kapital awalnya
        public readonly int Height;
        public readonly int Widht;

        //bikin constructor default -> kaya manggil fungsi biasa
        public Map (int height, int width)
        {
            Height = height;
            Widht = width;
        }

        //kita bikin behavior
        public bool onMap(Point point)
        {
            //ngecek point ada di map ngga
            var inBound = point.X < Widht && point.X >= 0 && point.Y < Height && point.Y >= 0;
            return inBound;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class MapLocation : Point //nah ini si anak kudu manggil bapaknya
    {
        //base (bapa) nya dipanggil, anaknya juga dikasih si constructornya
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.onMap(this))
            {
                throw new OutofBoundException(x + "," + y +" tidak ada di map");
            }
        }

        //ngecek kena apa engga tembakannya
        public bool inRangeOf(MapLocation location, int range)
        {
            return jarakKe(location) <= range;
        }
    }
}

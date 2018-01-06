using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Path
    {
        //underscroe buat konvensi penamaan developer lain
        private readonly MapLocation[] _path;
        public int Length => _path.Length;

        //default constructor
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation getLocation(int pathStep)
        {
            //syntatic sugar
            return (pathStep < _path.Length) ? _path[pathStep] : null;

        }
    }
}

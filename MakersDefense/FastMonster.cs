using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class FastMonster : Monster
    {
        public FastMonster(Path path) : base(path)
        {

        }

        public override int _stepSize { get; set; } = 2;
    }
}

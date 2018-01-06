using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class StrongMonster : Monster
    {
        public StrongMonster(Path path) : base(path)
        {

        }
            
        public override int Health { get; set; } = 3;

    }
}

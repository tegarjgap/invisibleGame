using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _power = 1;
        private const int _range = 1;
        private static readonly Random _random = new Random();
        private const double _accuracy = 0.75;

        //atribut
        public Tower(MapLocation location)
        {
            _location = location;
        }

        //behaviour
        public void TembakMonster(Monster [] monsters)
        {
            foreach(Monster monster in monsters)
            {
               if(_location.inRangeOf(monster.Location, _range) && monster.isActive)
                {
                    if(_random.NextDouble() < _accuracy)
                    {
                        monster.decreaseHealth(_power);
                        Console.WriteLine("tembakan kena");
                       // break; //buat keluar dari foreachnya

                    }
                    else
                    {
                        Console.WriteLine("tembakan miss");
                        break;
                    }
                   
                }
            }
        }
    }
}

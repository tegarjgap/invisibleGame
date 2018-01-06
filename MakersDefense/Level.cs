using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Level
    {
        private readonly Monster[] _monsters;
        public Tower[] towers { get; set; }

        public Level(Monster[] monsters)
        {
            _monsters = monsters;
        }

        public bool Play()
        {
            //waktu play looping sampai semua monster habis
            int sisaMonster = _monsters.Length;

            while(sisaMonster > 0)
            {
                //setiap tower bisa nembak monster
                foreach(Tower tower in towers)
                {
                    tower.TembakMonster(_monsters);
                }

                //abis nembak, itung kembali jumlah monster yg tersisa
                sisaMonster = 0;
                foreach(Monster monster in _monsters)
                {
                    if (monster.isActive)
                    {
                        monster.Maju();

                        //kalo menang game nya udahan
                        if (monster.HasScored)
                        {
                            return false;
                        }

                        sisaMonster++; //kalo belum menang di itung jumlah monsternya
                    }
                }
            }
            return true; //game masih jalan
        }
    }
}

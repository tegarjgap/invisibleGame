using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Monster
    {
        //si monster butuh jalan, readonly ngga bisa ada yg ngubah
        private readonly Path _path;
        private int _pathStep = 0;
        public virtual int Health { get; set; } = 2; //ini buat darah monster, dikasih virtual krna turunannya berubah
        public virtual int _stepSize { get; set; } = 1;

        public bool HasScored => _pathStep >= _path.Length; // buat skor si monster
        public bool isDead => Health <= 0; //pas si monster mati
        public bool isActive => !isDead && !HasScored;

       


        public MapLocation Location => _path.getLocation(_pathStep);

        //umumnya semua objek punya constructor
        public Monster(Path path)
        {
            _path = path;
        }

        public void Maju()
        {
            _pathStep += _stepSize;
        }

        public void decreaseHealth(int factor)
        {
            Health = factor;
            if (Health == 0)
                Console.WriteLine("monster mati");
        }
    }
}

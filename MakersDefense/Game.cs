using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class Game
    {    // program baca atas ke bawah pasti
        //jgn terlalu bnyak nyimpen kodingan di main
        //ideal nya nga boleh ada console write line
        static void Main(string[] args)
        {
            //new manggil objek baru nih, ntar objek yg dipanggil beda maksudnya
            Map map = new Map(5, 8); //ini kaya manggil fungsi lagi parameternya

            //but point nya nih
            //Point p = new Point(4, 2);
            //var isOnMap = map.onMap(p);
            //Console.WriteLine(isOnMap); buat nyetak hasil point nya true apa false

            //try catch bisa dibikin banyak
            try
            {
                MapLocation[] mapPath =
                {
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map),
                };

                Path path = new Path(mapPath);

                Monster[] monsters =
                {
                  
                    new Monster(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 2, map)),
                    new Tower(new MapLocation(3, 2, map)),  
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(3, 4, map)),
                    new Tower(new MapLocation(2, 3, map)),
                    new Tower(new MapLocation(2, 3, map)),
                    new Tower(new MapLocation(4, 3, map)),
                };

                Level level = new Level(monsters)
                {
                    towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " +((playerWon) ? "won" : "lost"));

                ///MapLocation location = path.getLocation(0);
                //Console.WriteLine(location.X + "," + location.Y);
            }
            catch (OutofBoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(MakersException)
            {
                Console.WriteLine("hayo error");
            }
            catch(Exception) // ini tuh global catch nya
            {
                Console.WriteLine("error duh");
            }

            //Point p2 = new Point(8, 2);

            //buktiin kalo jalan dan inherit
          
        }
    }
}

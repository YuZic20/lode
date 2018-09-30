using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lode
    {
        List<Lod> TemplateShips = new List<Lod>();
        


        public Lode()
        {
            GeneratePonorka();
            GenerateTorpedoborec();
            GenerateKriznik();
            GenerateBitevnik();
            GenerateLetadlova();
            GenerateHydroplan();
        }


        public Lod GetShip (int Type)
        {
            return TemplateShips[Type];
        }
        public void GeneratePonorka()
        {
            Position pivot = new Position()
            {
                PosX = 1,
                PosY = 1
            };

            List<Position> LodObsah = new List<Position>();
            LodObsah.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });

            Lod lod = new Lod("Ponorka", pivot, LodObsah, LodObsah, LodObsah, LodObsah);

            TemplateShips.Add(lod);
        }

        public void GenerateTorpedoborec()
        {
            Position pivot = new Position()
            {
                PosX = 1,
                PosY = 1
            };

            List<Position> LodObsah1 = new List<Position>();
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });

            List<Position> LodObsah2 = new List<Position>();
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });

            List<Position> LodObsah3 = new List<Position>();
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });

            List<Position> LodObsah4 = new List<Position>();
            LodObsah4.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });

            Lod lod = new Lod("Torpedoborec", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
        public void GenerateKriznik()
        {
            Position pivot = new Position()
            {
                PosX = 1,
                PosY = 1
            };

            List<Position> LodObsah1 = new List<Position>();
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });

            List<Position> LodObsah2 = new List<Position>();
            LodObsah2.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });

            List<Position> LodObsah3 = new List<Position>();
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });

            List<Position> LodObsah4 = new List<Position>();
            LodObsah4.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });

            Lod lod = new Lod("Kriznik", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
        public void GenerateBitevnik()
        {
            Position pivot = new Position()
            {
                PosX = 1,
                PosY = 1
            };

            List<Position> LodObsah1 = new List<Position>();
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -3
            });

            List<Position> LodObsah2 = new List<Position>();
            LodObsah2.Add(new Position
            {
                PosX = 0,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -3,
                PosY = -1
            });


            List<Position> LodObsah3 = new List<Position>();
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -0
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -3
            });

            List<Position> LodObsah4 = new List<Position>();
            LodObsah4.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -3,
                PosY = -1
            });

            Lod lod = new Lod("Bitevní Lod", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
        public void GenerateLetadlova()
        {
            Position pivot = new Position()
            {
                PosX = 1,
                PosY = 1
            };

            List<Position> LodObsah1 = new List<Position>();
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -3
            });
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -4
            });

            List<Position> LodObsah2 = new List<Position>();
            LodObsah2.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -3,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -4,
                PosY = -1
            });

            List<Position> LodObsah3 = new List<Position>();
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = 0
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -3
            });
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -4
            });

            List<Position> LodObsah4 = new List<Position>();
            LodObsah4.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -3,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -4,
                PosY = -1
            });

            Lod lod = new Lod("Letadlová lod", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
        public void GenerateHydroplan()
        {
            Position pivot = new Position()
            {
                PosX = 2,
                PosY = 2
            };

            List<Position> LodObsah1 = new List<Position>();
            LodObsah1.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah1.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah1.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });

            List<Position> LodObsah2 = new List<Position>();
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah2.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah2.Add(new Position
            {
                PosX = -1,
                PosY = -0
            });

            List<Position> LodObsah3 = new List<Position>();
            LodObsah3.Add(new Position
            {
                PosX = -1,
                PosY = -0
            });
            LodObsah3.Add(new Position
            {
                PosX = -0,
                PosY = -1
            });
            LodObsah3.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });

            List<Position> LodObsah4 = new List<Position>();
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -2
            });
            LodObsah4.Add(new Position
            {
                PosX = -2,
                PosY = -1
            });
            LodObsah4.Add(new Position
            {
                PosX = -1,
                PosY = -0
            });

            Lod lod = new Lod("Hydroplán", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
    }
}

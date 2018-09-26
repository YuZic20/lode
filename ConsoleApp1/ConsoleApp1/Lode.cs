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
        {/*
            public Lod ponorka = new Lod();
            public Lod torpedoborec = new Lod();
            public Lod kriznik = new Lod();
            public Lod bitevni = new Lod();
            public Lod letadlova = new Lod();*/
        }


        public Lod GetShip (int Type)
        {
            return TemplateShips[Type];
        }
        public void GeneratePonorka()
        {
            Pozice pivot = new Pozice()
            {
                PozX = 1,
                PozY = 1
            };

            List<Pozice> LodObsah = new List<Pozice>();
            LodObsah.Add(new Pozice
            {
                PozX = -1,
                PozY = -1
            });

            Lod lod = new Lod("Ponorka", pivot, LodObsah, LodObsah, LodObsah, LodObsah);

            TemplateShips.Add(lod);
        }

        public void GenerateTorpedoborec()
        {
            Pozice pivot = new Pozice()
            {
                PozX = 1,
                PozY = 1
            };

            List<Pozice> LodObsah1 = new List<Pozice>();
            LodObsah1.Add(new Pozice
            {
                PozX = -1,
                PozY = 0
            });
            LodObsah1.Add(new Pozice
            {
                PozX = -1,
                PozY = -1
            });

            List<Pozice> LodObsah2 = new List<Pozice>();
            LodObsah2.Add(new Pozice
            {
                PozX = -1,
                PozY = -1
            });
            LodObsah2.Add(new Pozice
            {
                PozX = -2,
                PozY = -1
            });

            List<Pozice> LodObsah3 = new List<Pozice>();
            LodObsah3.Add(new Pozice
            {
                PozX = -1,
                PozY = -1
            });
            LodObsah3.Add(new Pozice
            {
                PozX = -1,
                PozY = -2
            });

            List<Pozice> LodObsah4 = new List<Pozice>();
            LodObsah4.Add(new Pozice
            {
                PozX = -0,
                PozY = -1
            });
            LodObsah4.Add(new Pozice
            {
                PozX = -1,
                PozY = -1
            });

            Lod lod = new Lod("Torpedoborec", pivot, LodObsah1, LodObsah2, LodObsah3, LodObsah4);

            TemplateShips.Add(lod);
        }
    }
}

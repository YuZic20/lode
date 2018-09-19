using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lode
    {
        enum RotationState
        {
            Nahoru,
            Dolu,
            Vpravo,
            Vlevo
        }
        private string ShipType;
        private Pozice pivot;
        private List<Pozice> LodStav1;
        private List<Pozice> LodStav2;
        private List<Pozice> LodStav3;
        private List<Pozice> LodStav4;
        public Lode (string ShipType, Pozice pivot, List<Pozice> LodStav1, List<Pozice> LodStav2, List<Pozice> LodStav3, List<Pozice> LodStav4)
        {
            
        /*
        Pozice pivot = new Pozice()
        {
            PozX = 0,
            PozY = 0
        };

        List<Pozice> LodObsah = new List<Pozice>();
        LodObsah.Add(new Pozice
        {
            PozX = 0,
            PozY = 0
        });
        */
    }


    }
}

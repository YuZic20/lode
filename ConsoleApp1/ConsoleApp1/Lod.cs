using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lod
    {
        
        public string ShipType;
        public Pozice pivot;
        private List<Pozice> LodStav1;
        private List<Pozice> LodStav2;
        private List<Pozice> LodStav3;
        private List<Pozice> LodStav4;
		public List<Pozice> ShipTiles;
		RotationState ShipRotationState; // 1 = nahoru 2 = vpravo 3 = dolu 4 = vlevo
		
		

        public Lod(string ShipTypeI, Pozice pivotI, List<Pozice> LodStav1I, List<Pozice> LodStav2I, List<Pozice> LodStav3I, List<Pozice> LodStav4I)
        {
            ShipType = ShipTypeI;
            pivot = pivotI;
            LodStav1 = LodStav1I;
            LodStav2 = LodStav2I;
            LodStav3 = LodStav3I;
            LodStav4 = LodStav4I;
            ShipRotationState = RotationState.Nahoru;
            ShipTiles = LodStav1;

            //generace lode
        }

        public void ShipRotate(RotationState rotate) //rotace lodi
		{
			if (rotate == RotationState.Doprava)
			{
				if (ShipRotationState == RotationState.Doleva)
				{
					ShipRotationState = RotationState.Nahoru;
				}
				else
				{
					ShipRotationState++;
				}
			}
			else if (rotate == RotationState.Doleva)
			{
				if (ShipRotationState == RotationState.Nahoru)
				{
					ShipRotationState = RotationState.Doleva;
				}
				else
				{
					ShipRotationState--;
				}
            }
            if (ShipRotationState == RotationState.Nahoru)
			{
				ShipTiles = LodStav1;
			}
			else if (ShipRotationState == RotationState.Doprava)
			{
				ShipTiles = LodStav2;
			}
			else if (ShipRotationState == RotationState.Dolu)
			{
				ShipTiles = LodStav3;
			}
			else if (ShipRotationState == RotationState.Doleva)
			{
				ShipTiles = LodStav4;
			}
			
		}
			


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

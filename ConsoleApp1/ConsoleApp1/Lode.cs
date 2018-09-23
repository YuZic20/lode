using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lode
    {
        
        private string ShipType;
        private Pozice pivot;
        private List<Pozice> LodStav1;
        private List<Pozice> LodStav2;
        private List<Pozice> LodStav3;
        private List<Pozice> LodStav4;
		public List<Pozice> ShipRotationState;
		private int RotationState; // 1 = nahoru 2 = vpravo 3 = dolu 4 = vlevo
		/*
		enum RotationState
		{
			Nahoru,
			Vpravo,
			Dolu,
			Vlevo
		}
		*/
		public Lode (string ShipTypeI, Pozice pivotI, List<Pozice> LodStav1I, List<Pozice> LodStav2I, List<Pozice> LodStav3I, List<Pozice> LodStav4I)
        {
			ShipType = ShipTypeI;
			pivot = pivotI;
			LodStav1 = LodStav1I;
			LodStav2 = LodStav2I;
			LodStav3 = LodStav3I;
			LodStav4 = LodStav4I;
			RotationState = 1;

			//generace lode 

			void ShipRotate(string rotate) //rotace lodi
			{
				if (rotate == "R")
				{
					if (RotationState == 4)
					{
						RotationState = 1;
					}
					else
					{
						RotationState++;
					}
				}
				else if (rotate == "L")
				{
					if (RotationState == 1)
					{
						RotationState = 4;
					}
					else
					{
						RotationState--;
					}
				if (RotationState == 1)
				{
					ShipRotationState = LodStav1;
				}
				else if (RotationState == 2)
				{
					ShipRotationState = LodStav2;
				}
				else if (RotationState == 3)
				{
					ShipRotationState = LodStav3;
				}
				else if (RotationState == 4)
				{
					ShipRotationState = LodStav4;
				}
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
}

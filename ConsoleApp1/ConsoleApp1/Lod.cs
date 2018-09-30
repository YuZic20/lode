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
        public Position pivot;
        private List<Position> LodStav1;
        private List<Position> LodStav2;
        private List<Position> LodStav3;
        private List<Position> LodStav4;
		public List<Position> ShipTiles;
		RotationState ShipRotationState; // 1 = nahoru 2 = vpravo 3 = dolu 4 = vlevo
		
		

        public Lod(string ShipTypeI, Position pivotI, List<Position> LodStav1I, List<Position> LodStav2I, List<Position> LodStav3I, List<Position> LodStav4I)
        {
            ShipType = ShipTypeI;
            pivot = pivotI;
            LodStav1 = LodStav1I;
            LodStav2 = LodStav2I;
            LodStav3 = LodStav3I;
            LodStav4 = LodStav4I;
            ShipRotationState = RotationState.Up;
            ShipTiles = LodStav1;

            //generace lode
        }

        public void ShipRotate(RotationState rotate) //rotace lodi
		{
			if (rotate == RotationState.Right)
			{
				if (ShipRotationState == RotationState.Doleva)
				{
					ShipRotationState = RotationState.Up;
				}
				else
				{
					ShipRotationState++;
				}
			}
			else if (rotate == RotationState.Doleva)
			{
				if (ShipRotationState == RotationState.Up)
				{
					ShipRotationState = RotationState.Doleva;
				}
				else
				{
					ShipRotationState--;
				}
            }
            if (ShipRotationState == RotationState.Up)
			{
				ShipTiles = LodStav1;
			}
			else if (ShipRotationState == RotationState.Right)
			{
				ShipTiles = LodStav2;
			}
			else if (ShipRotationState == RotationState.Down)
			{
				ShipTiles = LodStav3;
			}
			else if (ShipRotationState == RotationState.Doleva)
			{
				ShipTiles = LodStav4;
			}
			
		}
			


		
		


    }
}

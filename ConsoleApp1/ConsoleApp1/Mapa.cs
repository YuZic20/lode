using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mapa
    {
        Lode Ships = new Lode();
        private int MapSize = 8;
		private List<Pozice> Map = new List<Pozice>();
		private List<int> MapState = new List<int>(); //0=voda; 1=potopena lod; 2= lod; 3 strela; 4 trefena lod; 5 = invalid spot
        private List<int> MapStateReal = new List<int>();
        private int MapMaxIndex = 0;
		private string Voda = "o";
		private string PotopenaLod = "X";
		private string Lod = "H";
		private string Strela = "X";
		private string TrefenaLod = "X";
		private Pozice Kurzor = new Pozice { PozX = 1, PozY = 1 };
		private int KurzorInt = 0;
        private RotationState Rotate = 0;
        private int help = 0;
        private string LastInput;
		//MapState[help] = 4;



		public void GenerateMap()
		{	
			for (int a = 1; a <= MapSize;a++)
                {
                for (int i = 1; i <= MapSize; i++)
                    {
					MapState.Add(0);
                    Map.Add(new Pozice
                    {
                        PozX = i,
                        PozY = a
                    });
                }
            }
			MapMaxIndex = Map.Count;
            MapStateReal = MapState;
			
		}


		public void PrintMap()
		{
            
            KurzorInt = (Kurzor.PozX - 1) + ((Kurzor.PozY - 1) * MapSize);
			int TableHelper = 1;
			for (int i = 1; i <= MapSize; i++) // vypsání čísel top
			{
				Console.Write((i)+ " ");
			}
			Console.WriteLine();
			for (int i = 1; i <= MapMaxIndex; i++)
			{
				if (KurzorInt == i-1)
				{
					Console.BackgroundColor = ConsoleColor.White;
				}
				
				if (i % MapSize == 0 || i == 0)
				{
					if (MapState[i-1] == 0)
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write(Voda);
						Console.ResetColor();
						Console.Write(" ");
						
					}
					else if (MapState[i-1] == 1)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(PotopenaLod);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 2)
					{
                        Console.ResetColor();
                        Console.Write(Lod + " ");
                        					}
					else if (MapState[i - 1] == 3)
					{
                        Console.ResetColor();
                        Console.Write(Strela + " ");
					}
					else if (MapState[i - 1] == 4)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(TrefenaLod);
						Console.ResetColor();
						Console.Write(" ");
					}

				Console.WriteLine(" " + (TableHelper));
				TableHelper++;
				}
					
				else
				{
					if (MapState[i - 1] == 0)
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write(Voda);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 1)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(PotopenaLod);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 2)
					{
                        Console.ResetColor();
                        Console.Write(Lod + " ");
					}
					else if (MapState[i - 1] == 3)
					{
                        Console.ResetColor();
                        Console.Write(Strela + " ");
					}
					else if (MapState[i - 1] == 4)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(TrefenaLod);
						Console.ResetColor();
						Console.Write(" ");
					}
				}
			}
			Console.WriteLine("PozX= " + Kurzor.PozX);
			Console.WriteLine("PozY= " + Kurzor.PozY);
            MapState = MapStateReal.ToList();
            Rotate = RotationState.Unset;
        }
		public void MapKurzor(string Input)
		{
            LastInput = Input;
			if (Input == "w")
			{
				if (Kurzor.PozY > 1)
				{
					Kurzor.PozY--;
				}
				
			}
			else if (Input == "d")
			{
				if (Kurzor.PozX < MapSize)
				{
					Kurzor.PozX++;
				}
			}
			else if (Input == "s")
			{
				if (Kurzor.PozY < MapSize)
				{
					Kurzor.PozY++;
				}
			}
			else if (Input == "a")
			{
				if (Kurzor.PozX > 1)
				{
					Kurzor.PozX--;
				}
            }
            else if ( Input == "e")
            {
                Rotate = RotationState.Doprava;
            }
            else if (Input == "q")
            {
                Rotate = RotationState.Doleva;
            }
        }
        public void PlaceShip(Lod Input)
        {

            


            if (Rotate != RotationState.Unset)
            {
                Input.ShipRotate(Rotate);
            }
            Console.WriteLine("pokládáš: " + Input.ShipType);
            Kurzor = Input.pivot;
            int ShipMaxIndex = Input.ShipTiles.Count;
            Pozice ShipTile = new Pozice();
            int ShipInt;
            int KurzorInt = (Kurzor.PozX) + ((Kurzor.PozY) * MapSize);                       
            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PozX + Kurzor.PozX) + ((ShipTile.PozY + Kurzor.PozY) * MapSize);

                if (ShipTile.PozX + Kurzor.PozX >= 0 && ShipTile.PozX + Kurzor.PozX <= MapSize-1)
                {

                }
                else
                {
                    Console.WriteLine("not able place!!!3");
                }
                

                    if (ShipInt < MapMaxIndex && ShipInt >= 0 )/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {
                    MapState[ShipInt] = 2;
                }
                else
                {
                    //not able place!!!
                    Console.WriteLine("not able place!!!2");
                }
                
                
            }
            

        }

    }
}

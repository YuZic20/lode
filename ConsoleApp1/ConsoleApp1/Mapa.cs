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
        private int MapSize = 10;
		private List<Pozice> Map = new List<Pozice>();
		private List<int> MapState = new List<int>(); //0=voda; 1=potopena lod; 2= lod; 3 strela; 4 trefena lod; 5 = invalid spot
		int MapMaxIndex = 0;
		private string Voda = "o";
		private string PotopenaLod = "X";
		private string Lod = "H";
		private string Strela = "X";
		private string TrefenaLod = "X";
		private Pozice Kurzor = new Pozice { PozX = 1, PozY = 1 };
		private int KurzorInt = 0;
		int help = 0; 
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
						Console.Write(Lod + " ");
					}
					else if (MapState[i - 1] == 3)
					{
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
						Console.Write(Lod + " ");
					}
					else if (MapState[i - 1] == 3)
					{
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
		}
		public void MapKurzor(string Input)
		{
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
		}
        public void PlaceShip(Lod Input)
        {
            Console.WriteLine("pokládáš: " + Input.ShipType);

            int ShipMaxIndex = Input.ShipTiles.Count;
            Pozice ShipTile = new Pozice();
            int ShipInt;
            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PozX + Kurzor.PozX - 1) + ((ShipTile.PozY + Kurzor.PozY - 1) * MapSize);
                MapState[ShipInt] = 2;
            }
            

        }

    }
}

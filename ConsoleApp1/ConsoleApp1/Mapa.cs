using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mapa
    {
        private int MapSize = 10;
		private List<Pozice> Map = new List<Pozice>();
		private List<int> MapState = new List<int>(); //0 = voda 1 =potopena lod 2= lod 3 strela 4 strefena lod
		int MapMaxIndex = 0;
		private string Voda = "o";
		private string PotopenaLod = "X";
		private string Lod = "H";
		private string Strela = "X";
		private string TrefenaLod = "X";

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
			/*int help = (10-1)+((4-1)*MapSize); //x-1 +y-1*mapsize
			MapState[help] = 4;*/
		}


		public void PrintMap()
		{
			int TableHelper = 1;
			for (int i = 1; i <= MapSize; i++) // vypsání čísel top
			{
				Console.Write((i)+ " ");
			}
			Console.WriteLine();
			for (int i = 1; i <= MapMaxIndex; i++)
			{
				
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
		}

	}
}

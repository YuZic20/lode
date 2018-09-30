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
        private List<List<int>> HitShips = new List<List<int>>();
        private List<List<int>> HitShipsReal = new List<List<int>>();
        private int HitShipsIndex = 0;
        private List<int> MapState = new List<int>();
        private List<int> MapStatePlayer = new List<int>();//0=voda; 1=potopena lod; 2= lod; 3 strela; 4 trefena lod; 5 = invalid spot
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
        //private int help = 0;
        private string LastInput;
        private bool AbleToPlace = false;
        private bool Place = false;
        private int DestroyedShipsCount = 0;
        public string TextToPlayer = "";
        public int NumOFShips = 0;

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
            MapStatePlayer = MapState;



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
					//Console.BackgroundColor = ConsoleColor.White;
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
                    else if (MapState[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
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
                    else if (MapState[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
                        Console.ResetColor();
                        Console.Write(" ");

                    }
                }
			}
            MapState = MapStateReal.ToList();           
            HitShips = HitShipsReal.ToList();
        Rotate = RotationState.Unset;
            Place = false;
        }
        public void PrintMapToHit()
        {

            KurzorInt = (Kurzor.PozX - 1) + ((Kurzor.PozY - 1) * MapSize);
            int TableHelper = 1;
            for (int i = 1; i <= MapSize; i++) // vypsání čísel top
            {
                Console.Write((i) + " ");
            }
            Console.WriteLine();
            for (int i = 1; i <= MapMaxIndex; i++)
            {
                if (KurzorInt == i - 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }

                if (i % MapSize == 0 || i == 0)
                {
                    if (MapStatePlayer[i - 1] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
                        Console.ResetColor();
                        Console.Write(" ");

                    }
                    else if (MapStatePlayer[i - 1] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(PotopenaLod);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 2)
                    {
                        Console.ResetColor();
                        Console.Write(Lod + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 3)
                    {
                        Console.ResetColor();
                        Console.Write(Strela + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(TrefenaLod);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
                        Console.ResetColor();
                        Console.Write(" ");

                    }

                    Console.WriteLine(" " + (TableHelper));
                    TableHelper++;
                }

                else
                {
                    if (MapStatePlayer[i - 1] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(PotopenaLod);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 2)
                    {
                        Console.ResetColor();
                        Console.Write(Lod + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 3)
                    {
                        Console.ResetColor();
                        Console.Write(Strela + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(TrefenaLod);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Voda);
                        Console.ResetColor();
                        Console.Write(" ");

                    }
                }
            }
            Console.WriteLine("PozX= " + Kurzor.PozX);
            Console.WriteLine("PozY= " + Kurzor.PozY);
            MapState = MapStateReal.ToList();
            HitShips = HitShipsReal.ToList();
            Rotate = RotationState.Unset;
            Place = false;

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
            else if (Input == " ")
            {
                Place = true;
            }
        }
        public void PlaceShip(Lod Input)
        {

            


            if (Rotate != RotationState.Unset)
            {
                Input.ShipRotate(Rotate);
            }
            TextToPlayer = "pokládáš: " + Input.ShipType;
            List<Pozice> ValidShip = new List<Pozice>();
            Kurzor = Input.pivot;
            int ShipMaxIndex = Input.ShipTiles.Count;
            int BadCount = 0;
            Pozice ShipTile = new Pozice();
            int ShipInt;
            int KurzorInt = (Kurzor.PozX) + ((Kurzor.PozY) * MapSize);
            AbleToPlace = true;
            HitShips.Add(new List<int> { 0 });
            for (int i = 0; i < ShipMaxIndex ; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PozX + Kurzor.PozX) + ((ShipTile.PozY + Kurzor.PozY) * MapSize);

                ValidShip.Add(new Pozice
                {
                    PozX = ShipTile.PozX + Kurzor.PozX + 1,
                    PozY = ShipTile.PozY + Kurzor.PozY
                });
                ValidShip.Add(new Pozice
                {
                    PozX = ShipTile.PozX + Kurzor.PozX - 1,
                    PozY = ShipTile.PozY + Kurzor.PozY 
                });
                ValidShip.Add(new Pozice
                {
                    PozX = ShipTile.PozX + Kurzor.PozX ,
                    PozY = ShipTile.PozY + Kurzor.PozY + 1
                });
                ValidShip.Add(new Pozice
                {
                    PozX = ShipTile.PozX + Kurzor.PozX ,
                    PozY = ShipTile.PozY + Kurzor.PozY - 1
                });

                if (ShipTile.PozX + Kurzor.PozX >= 0 && ShipTile.PozX + Kurzor.PozX <= MapSize-1)
                {
              
                }
                else
                {
                    TextToPlayer = "Zde nelze položit lod";
                    BadCount++;
                }
                

                if (ShipInt < MapMaxIndex && ShipInt >= 0 )/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {
                    if (MapState[ShipInt] != 0)
                    {
                        BadCount++;
                    }
                    MapState[ShipInt] = 2;
                    HitShips[HitShipsIndex].Add(ShipInt);


                }
                else
                {
                    //not able place!!!
                    TextToPlayer = "Zde nelze polozit lod";
                    BadCount++;
                }
            
                    

                                           
            }
            if (BadCount == 0 && Place == true )
                {
                int ShipValidInt;
                Pozice ShipValidTile = new Pozice();

 
                for (int i = 0; i < ValidShip.Count; i++)
                    {
                    AbleToPlace = true;
                    ShipValidTile = ValidShip[i];
                    ShipValidInt = (ShipValidTile.PozX) + ((ShipValidTile.PozY) * MapSize);

                    if (ShipValidTile.PozX >= 0 && ShipValidTile.PozX <= MapSize - 1)
                    {
                        
                    }
                    else
                    {
                        AbleToPlace = false;
                    }


                    if (ShipValidInt < MapMaxIndex && ShipValidInt >= 0)
                    {
                        
                        if (MapState[ShipValidInt] == 0 && AbleToPlace == true)
                        {
                            MapState[ShipValidInt] = 5;
                        }
                        



                    }
                    else
                    {
                       
                        AbleToPlace = false;
                    }
                }
                NumOFShips++;
                MapStateReal = MapState.ToList();
                HitShipsReal = HitShips.ToList();
                HitShipsIndex++;
            }





        }
        public void Shoot(Lod Input)
        {
            if (Rotate != RotationState.Unset)
            {
                Input.ShipRotate(Rotate);
            }
            List<int> MapShipShoot = new List<int>();
            TextToPlayer = "Používáš ostrou munici";
            Kurzor = Input.pivot;
            int ShipMaxIndex = Input.ShipTiles.Count;
            int BadCount = 0;
            Pozice ShipTile = new Pozice();
            int ShipInt;
            int KurzorInt = (Kurzor.PozX) + ((Kurzor.PozY) * MapSize);
            AbleToPlace = true;
            
            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PozX + Kurzor.PozX) + ((ShipTile.PozY + Kurzor.PozY) * MapSize);



                if (ShipTile.PozX + Kurzor.PozX >= 0 && ShipTile.PozX + Kurzor.PozX <= MapSize - 1)
                {

                }
                else
                {
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }


                if (ShipInt < MapMaxIndex && ShipInt >= 0)/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {
                    
                    
                    if(MapState[ShipInt] == 2)
                    {
                        MapShipShoot.Add(ShipInt);
                    }
                    MapState[ShipInt] = 3;


                }
                else
                {
                    //not able place!!!
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }




            }
            if (BadCount == 0 && Place == true)
            {
                

                for (int i = 0; i < MapShipShoot.Count(); i++)
                {
                    ShipInt = MapShipShoot[i];

                    if (MapState[ShipInt] == 2)
                    {
                        MapState[ShipInt] = 4;
                        for (int d = 0; d <= HitShips.Count; d++)
                        {
                            int count = 0;
                            for (int g = 1; g <= HitShips[d].Count; g++)
                            {
                                if (HitShips[d][g] == ShipInt)
                                {
                                    HitShips[d][0]++;
                                    if (HitShips[d][0] == HitShips[d].Count - 1)
                                    {
                                        for (int f = 1; f <= HitShips[d].Count; f++)
                                        {
                                            MapState[HitShips[d][f]] = 1;
                                            

                                        }
                                        DestroyedShipsCount++;
                                        HitShips[d][0] = 9999999;

                                    }
                                }
                                
                            }
                        }
                    }

                    
                 }


                MapStateReal = MapState.ToList();
                HitShipsReal = HitShips.ToList();
            }




        }
        public void Discover(Lod Input)
        {
            if (Rotate != RotationState.Unset)
            {
                Input.ShipRotate(Rotate);
            }
            List<int> MapShipShoot = new List<int>();
            TextToPlayer = "Používáš slepou munici";
            Kurzor = Input.pivot;
            int ShipMaxIndex = Input.ShipTiles.Count;
            int BadCount = 0;
            Pozice ShipTile = new Pozice();
            int ShipInt;
            int KurzorInt = (Kurzor.PozX) + ((Kurzor.PozY) * MapSize);
            AbleToPlace = true;

            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PozX + Kurzor.PozX) + ((ShipTile.PozY + Kurzor.PozY) * MapSize);



                if (ShipTile.PozX + Kurzor.PozX >= 0 && ShipTile.PozX + Kurzor.PozX <= MapSize - 1)
                {

                }
                else
                {
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }


                if (ShipInt < MapMaxIndex && ShipInt >= 0)/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {


                    if (MapState[ShipInt] == 2)
                    {
                        MapShipShoot.Add(ShipInt);
                    }
                    MapState[ShipInt] = 3;


                }
                else
                {
                    //not able place!!!
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }




            }
            if (BadCount == 0 && Place == true)
            {

                for (int i = 0; i < MapShipShoot.Count(); i++)
                {
                    ShipInt = MapShipShoot[i];

                    if (MapState[ShipInt] == 2)
                    {
                        MapStatePlayer[ShipInt] = 2;
                        
                    }


                }


                MapStateReal = MapState.ToList();
                HitShipsReal = HitShips.ToList();


            }
        }
        public bool DestroyedShips()
        {
            if(HitShipsIndex == DestroyedShipsCount)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}


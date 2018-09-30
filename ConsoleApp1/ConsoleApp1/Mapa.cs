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
		private List<Position> Map = new List<Position>();
        private List<List<int>> HitShips = new List<List<int>>();
        private List<List<int>> HitShipsReal = new List<List<int>>();
        private int HitShipsIndex = 0;
        private List<int> MapState = new List<int>();
        private List<int> MapStatePlayer = new List<int>();//0=voda; 1=potopena lod; 2= lod; 3 strela; 4 trefena lod; 5 = invalid spot
        private List<int> MapStatePlayerReal = new List<int>();//0=voda; 1=potopena lod; 2= lod; 3 strela; 4 trefena lod; 5 = invalid spot
        private List<int> MapStateReal = new List<int>();
        private int MapMaxIndex = 0;
		private string Watter = "o";
		private string Sunken = "X";
		private string Ship = "H";
		private string NotHit = "X";
		private string Hit = "X";
		private Position Kurzor = new Position { PosX = 1, PosY = 1 };
		private int KurzorInt = 0;
        private RotationState Rotate = 0;
        //private int help = 0;
        private string LastInput;
        private bool AbleToPlace = false;
        private bool Place = false;
        private int DestroyedShipsCount;
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
                    Map.Add(new Position
                    {
                        PosX = i,
                        PosY = a
                    });
                }
            }
			MapMaxIndex = Map.Count;
            MapStateReal = MapState;
            MapStatePlayer = MapState;
            MapStatePlayerReal = MapStatePlayer;



        }


		public void PrintMap()
		{
            
            KurzorInt = (Kurzor.PosX - 1) + ((Kurzor.PosY - 1) * MapSize);
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
						Console.Write(Watter);
						Console.ResetColor();
						Console.Write(" ");
						
					}
					else if (MapState[i-1] == 1)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Sunken);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 2)
					{
                        Console.ResetColor();
                        Console.Write(Ship + " ");
                        					}
					else if (MapState[i - 1] == 3)
					{
                        Console.ResetColor();
                        Console.Write(NotHit + " ");
					}
					else if (MapState[i - 1] == 4)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(Hit);
						Console.ResetColor();
						Console.Write(" ");
					}
                    else if (MapState[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Watter);
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
						Console.Write(Watter);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 1)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Sunken);
						Console.ResetColor();
						Console.Write(" ");
					}
					else if (MapState[i - 1] == 2)
					{
                        Console.ResetColor();
                        Console.Write(Ship + " ");
					}
					else if (MapState[i - 1] == 3)
					{
                        Console.ResetColor();
                        Console.Write(NotHit + " ");
					}
					else if (MapState[i - 1] == 4)
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write(Hit);
						Console.ResetColor();
						Console.Write(" ");
					}
                    else if (MapState[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Watter);
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

            KurzorInt = (Kurzor.PosX - 1) + ((Kurzor.PosY - 1) * MapSize);
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
                    //Console.BackgroundColor = ConsoleColor.White;
                }

                if (i % MapSize == 0 || i == 0)
                {
                    if (MapStatePlayer[i - 1] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Watter);
                        Console.ResetColor();
                        Console.Write(" ");

                    }
                    else if (MapStatePlayer[i - 1] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Sunken);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 2)
                    {
                        Console.ResetColor();
                        Console.Write(Ship + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 3)
                    {
                        Console.ResetColor();
                        Console.Write(NotHit + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Hit);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Watter);
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
                        Console.Write(Watter);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Sunken);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 2)
                    {
                        Console.ResetColor();
                        Console.Write(Ship + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 3)
                    {
                        Console.ResetColor();
                        Console.Write(NotHit + " ");
                    }
                    else if (MapStatePlayer[i - 1] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Hit);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else if (MapStatePlayer[i - 1] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(Watter);
                        Console.ResetColor();
                        Console.Write(" ");

                    }
                }
            }
            MapState = MapStateReal.ToList();
            MapStatePlayer = MapStatePlayerReal.ToList();
            HitShips = HitShipsReal.ToList();
            Rotate = RotationState.Unset;
            Place = false;

        }
        public void MapKurzor(string Input)
		{
            LastInput = Input;
			if (Input == "w")
			{
				if (Kurzor.PosY > 1)
				{
					Kurzor.PosY--;
				}
				
			}
			else if (Input == "d")
			{
				if (Kurzor.PosX < MapSize)
				{
					Kurzor.PosX++;
				}
			}
			else if (Input == "s")
			{
				if (Kurzor.PosY < MapSize)
				{
					Kurzor.PosY++;
				}
			}
			else if (Input == "a")
			{
				if (Kurzor.PosX > 1)
				{
					Kurzor.PosX--;
				}
            }
            else if ( Input == "e")
            {
                Rotate = RotationState.Right;
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
            TextToPlayer = "Pokládáš: " + Input.ShipType;
            List<Position> ValidShip = new List<Position>();
            Kurzor = Input.pivot;
            int ShipMaxIndex = Input.ShipTiles.Count;
            int BadCount = 0;
            Position ShipTile = new Position();
            int ShipInt;
            int KurzorInt = (Kurzor.PosX) + ((Kurzor.PosY) * MapSize);
            AbleToPlace = true;
            HitShips.Add(new List<int> { 0 });
            for (int i = 0; i < ShipMaxIndex ; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PosX + Kurzor.PosX) + ((ShipTile.PosY + Kurzor.PosY) * MapSize);

                ValidShip.Add(new Position
                {
                    PosX = ShipTile.PosX + Kurzor.PosX + 1,
                    PosY = ShipTile.PosY + Kurzor.PosY
                });
                ValidShip.Add(new Position
                {
                    PosX = ShipTile.PosX + Kurzor.PosX - 1,
                    PosY = ShipTile.PosY + Kurzor.PosY 
                });
                ValidShip.Add(new Position
                {
                    PosX = ShipTile.PosX + Kurzor.PosX ,
                    PosY = ShipTile.PosY + Kurzor.PosY + 1
                });
                ValidShip.Add(new Position
                {
                    PosX = ShipTile.PosX + Kurzor.PosX ,
                    PosY = ShipTile.PosY + Kurzor.PosY - 1
                });

                if (ShipTile.PosX + Kurzor.PosX >= 0 && ShipTile.PosX + Kurzor.PosX <= MapSize-1)
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
                        TextToPlayer = "Zde nelze polozit lod";
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
                Position ShipValidTile = new Position();

 
                for (int i = 0; i < ValidShip.Count; i++)
                    {
                    AbleToPlace = true;
                    ShipValidTile = ValidShip[i];
                    ShipValidInt = (ShipValidTile.PosX) + ((ShipValidTile.PosY) * MapSize);

                    if (ShipValidTile.PosX >= 0 && ShipValidTile.PosX <= MapSize - 1)
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
            Position ShipTile = new Position();
            int ShipInt;
            int KurzorInt = (Kurzor.PosX) + ((Kurzor.PosY) * MapSize);
            AbleToPlace = true;
            
            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PosX + Kurzor.PosX) + ((ShipTile.PosY + Kurzor.PosY) * MapSize);



                if (ShipTile.PosX + Kurzor.PosX >= 0 && ShipTile.PosX + Kurzor.PosX <= MapSize - 1)
                {

                }
                else
                {
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }


                if (ShipInt < MapMaxIndex && ShipInt >= 0)/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {
                    
                    
                    if(MapState[ShipInt] == 2 || MapState[ShipInt] == 0)
                    {
                        MapShipShoot.Add(ShipInt);
                    }

                    MapStatePlayer[ShipInt] = 3;
                    


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
                MapStatePlayer = MapStatePlayerReal.ToList();
                MapState = MapStateReal.ToList(); 
                for (int i = 0; i < MapShipShoot.Count(); i++)
                {
                    ShipInt = MapShipShoot[i];

                    if (MapStateReal[ShipInt] == 2)
                    {
                        MapState[ShipInt] = 4;
                        MapStatePlayer[ShipInt] = 4;
                        for (int d = 0; d < HitShips.Count; d++)
                        {
                            for (int g = 1; g < HitShips[d].Count; g++)
                            {
                                if (HitShips[d][g] == ShipInt)
                                {
                                    HitShips[d][0]++;
                                    if (HitShips[d][0] == HitShips[d].Count - 1)
                                    {
                                        for (int f = 1; f < HitShips[d].Count; f++)
                                        {
                                            MapState[HitShips[d][f]] = 1;
                                            MapStatePlayer[HitShips[d][f]] = 1;



                                        }
                                        DestroyedShipsCount++;
                                        HitShips[d][0] = 9999999;

                                    }
                                }
                                
                            }
                        }
                    }else if (MapStateReal[ShipInt] == 0)
                    {
                        MapStatePlayer[ShipInt] = 3;
                    }

                    
                 }

                MapStatePlayerReal = MapStatePlayer.ToList();
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
            Position ShipTile = new Position();
            int ShipInt;
            int KurzorInt = (Kurzor.PosX) + ((Kurzor.PosY) * MapSize);
            AbleToPlace = true;

            for (int i = 0; i < ShipMaxIndex; i++)
            {
                ShipTile = Input.ShipTiles[i];
                ShipInt = (ShipTile.PosX + Kurzor.PosX) + ((ShipTile.PosY + Kurzor.PosY) * MapSize);



                if (ShipTile.PosX + Kurzor.PosX >= 0 && ShipTile.PosX + Kurzor.PosX <= MapSize - 1)
                {

                }
                else
                {
                    TextToPlayer = "Zde nemůžeš střílet";
                    BadCount++;
                }


                if (ShipInt < MapMaxIndex && ShipInt >= 0)/*&& MapSize * (b - 1) <= ShipInt && MapSize * b >= ShipInt*/
                {


                    if (MapState[ShipInt] == 2 || MapState[ShipInt] == 0)
                    {
                        MapShipShoot.Add(ShipInt);
                    }
                    
                    
                    MapStatePlayer[ShipInt] = 3;


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
                MapStatePlayer = MapStatePlayerReal.ToList();

                for (int i = 0; i < MapShipShoot.Count(); i++)
                {
                    ShipInt = MapShipShoot[i];

                    if (MapStateReal[ShipInt] == 2)
                    {
                        MapStatePlayer[ShipInt] = 2;

                        
                    }else
                    {
                        MapStatePlayer[ShipInt] = 3;
                    }


                }

                MapStatePlayerReal= MapStatePlayer.ToList();
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
        public void RemoveInvalid()
        {
             for (int i = 0; i < MapMaxIndex; i++)
            {

                if (MapState[i] == 5)
                {
                    MapState[i] = 0;
                    MapStateReal[i] = 0;
                    MapStatePlayerReal[i] = 0;
                    MapStatePlayer[i] = 0;
                }
            }


        }

    }
}


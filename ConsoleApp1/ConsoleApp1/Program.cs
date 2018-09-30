using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum RotationState
    {
        Nahoru,
        Doprava,
        Dolu,
        Doleva,
        Unset
    }
    class Program
    {
        static void Main(string[] args)
        {

            



        Lode Ships = new Lode();
            Ships.GeneratePonorka();
            Ships.GenerateTorpedoborec();
            Ships.GenerateKriznik();
            Ships.GenerateBitevnik();
            Ships.GenerateLetadlova();
            Ships.GenerateHydroplan();
            ConsoleKeyInfo input;
			string inputToKursor;
			bool game = true;

			Mapa Mapa1 = new Mapa();
            Mapa Mapa2 = new Mapa();
            Mapa1.GenerateMap();
            Mapa2.GenerateMap();

            while (game)
			{
                Console.WriteLine("Hráči 1 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (Mapa1.NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(4));
                        
                    }
                    else if (Mapa1.NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(3));
                        
                    }
                    else if (Mapa1.NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(2));
                    }
                    else if (Mapa1.NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(5));
                    }
                    else if (Mapa1.NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(1));
                    }
                    else if (Mapa1.NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Hráči 2 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (Mapa2.NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(4));

                    }
                    else if (Mapa2.NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(3));

                    }
                    else if (Mapa2.NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(2));
                    }
                    else if (Mapa2.NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(5));
                    }
                    else if (Mapa2.NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(1));
                    }
                    else if (Mapa2.NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships.GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }








            }

		}
    }
}

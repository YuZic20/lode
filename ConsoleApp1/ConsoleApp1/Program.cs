﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Lode Ships = new Lode();
            Ships.GeneratePonorka();
            Ships.GenerateTorpedoborec();
            ConsoleKeyInfo input;
			string inputToKursor;
			bool game = true;

			Mapa Mapa = new Mapa();
            Mapa.GenerateMap();
			

			while (game)
			{
				Mapa.PrintMap();
				input = Console.ReadKey();
				inputToKursor = input.KeyChar.ToString();
				Mapa.MapKurzor(inputToKursor);
                Mapa.PlaceShip(Ships.GetShip(1));
				Console.Clear();

			}

		}
    }
}

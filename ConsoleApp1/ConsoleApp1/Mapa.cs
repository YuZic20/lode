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
        
        public void GenerateMap()
        {
            List<Pozice> Map = new List<Pozice>();
            for (int a = 1; a <= MapSize;a++)
                {
                for (int i = 1; i <= MapSize; i++)
                    {
                    Map.Add(new Pozice
                    {
                        PozX = i,
                        PozY = a
                    });           


                }
            }
        }
        
    }
}

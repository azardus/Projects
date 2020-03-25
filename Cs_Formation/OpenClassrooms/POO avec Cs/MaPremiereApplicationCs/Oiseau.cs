using MaPremiereApplicationCs.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApplicationCs
{
    class Oiseau : IVolant
    {
        public int NombrePropulseur { get ; set ; }

        public void Voler()
        {
            Console.WriteLine(" L'oiseau vole grace à " + NombrePropulseur + " ailes.");
        }
    }
}

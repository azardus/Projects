using System;
using System.Collections.Generic;
using System.Text;
using MaPremiereApplicationCs.Interface;

namespace MaPremiereApplicationCs
{
    class Avion : IVolantMotorise, IRouler, IVolant
    {
        public int NombrePropulseur { get; set; }
        public string MarqueDeCompanie { get; set; }
        public int NombreDeRoue { get; set; }

        public void DemarrerLeMoteur()
        {
        }

        public void Voler()
        {
            Console.WriteLine(" L'avion vole grace à " + NombrePropulseur + " turbines");
            // throw new NotImplementedException();
        }

        public void Rouler()
        {
            Console.WriteLine(" Je roule, je vais pouvoir bientôt décoller");
        }
    }
}

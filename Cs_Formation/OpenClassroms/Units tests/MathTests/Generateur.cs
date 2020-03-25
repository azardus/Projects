using MathTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTests
{
    public class Generateur : IGenerateur
    {
        private Random r;
        public Generateur()
        {
            r = new Random();
        }

        public int Valeur
        {
            get { return r.Next(0, 100); }
        }
    }
}

using System;

namespace _20_calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatrice :");
            Console.WriteLine("--------------");

            Calculer calcul = new Calculer(5);
            // Le but de l'objet = Appliquer une operation sur mon objet 

            double r;
            r = calcul.GetResult();

            Calculer.DireBonjour();
            

        }

    }

    class Calculer
    {
        protected double _result;

        
        public Calculer(double value)
        {
            this._result = value;

        }

        public double Add(double value)
        {
           _result = value + this._result;
            return _result;
        }

        public double GetResult()
        {
           return this._result;
        }

       public static void DireBonjour()
        {
            Console.WriteLine("hello le monde");
        }


    }
}

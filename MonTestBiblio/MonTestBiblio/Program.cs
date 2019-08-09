using System;
using mbc2 = MaBiblioDeClasse2;
using mbc1 = MaBiblioDeClasse;

namespace MonTestBiblio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            mbc2.MaClass1 c1 = new mbc2.MaClass1()
            {
                Prenom = "Jeremie"
            };

            Console.WriteLine (c1.Prenom);

            mbc1.MaClass1 c2 = new mbc1.MaClass1()
            {
                MonNom2 = "Ange"
            };

            Console.WriteLine(c2.MonNom2);
        }
    }
}

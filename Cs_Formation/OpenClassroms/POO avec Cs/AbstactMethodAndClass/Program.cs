using System;

namespace AbstactMethodAndClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Chien unChien = new Chien();
            unChien.SeDeplacer();
            unChien.Aboyer();
            unChien.Mourrir();
            
            Animal unAutreChien = new Chien();
            unAutreChien.NombreDePattes = 4;

            Chat unChat = new Chat();
            unChat.Naissance(1);
            unChat.Miauller();
            unChat.prenom = " Grosminet";
        }
    }
}

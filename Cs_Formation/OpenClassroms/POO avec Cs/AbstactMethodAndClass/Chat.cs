using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactMethodAndClass
{
    class Chat : Animal
    {
        public override void SeDeplacer()
        {
            Console.WriteLine(" Le chat : Se deplace avec override");
        }
        public void Miauller()
        {
            Console.WriteLine(" Le chat : Miiaaooouuuu");
        }
    }
}

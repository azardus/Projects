using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactMethodAndClass
{
    public class Chien : Animal
    {
        public override void SeDeplacer()
        {
            Console.WriteLine(" Le chien : Se déplace sur 4 pattes");
        }
        public void Aboyer()
        {
            Console.WriteLine(" Le chien : Wouf Wouf ");
        }

    }
}

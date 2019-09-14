using System;

namespace _18_VirtualEtOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Virtual et Override");
            Console.WriteLine("-------------------");

            Animal unAnimal = new Animal("titi");
            Console.WriteLine($"{unAnimal.Grogner()}");

            Dog monChien = new Dog("Rex", 3);
            Console.WriteLine($"{monChien.Grogner()}");
            monChien.SetName("Fulgor");
            //fulgor = "Fulgor";
            //monChien.SetName(fulgor);

            unAnimal.Name = "titi";


        }

        class Animal
        {
            protected string _name;
            protected byte _age;
            protected string _grognement;

            public string Name 
            { 
                get => _name; 
                set 
                { 
                    _name = value; 
                }
            }

            public string Age { get; set; }
            

            public Animal(string name)
            {
                Console.WriteLine("[Animal] RRRR ");
                _name = name;
            }   
            public virtual string Grogner()
            { 

                return "[Animal] GROOOORRRR de la fonciton Grogner";
            }
            public string GetName()
            {
                return name;
            }
            public string SetName(string name)
            {
                return name;
            }
        }
        class Dog : Animal
        {
            protected string couleur;
            public string str = Console.WriteLine("[Dog]");
            public Dog(string name, byte age) : base(str)
            {
                Console.WriteLine($"[Dog] Mon Dog qui herite d'Animal s'appel {name} et a {age} ans.");
            }
            public override string Grogner()
            {
                return "[Dog] RRRR de Dog";
            }
            // est-il possible d'avoir plusieurs override ?

        }
        // quesque mes 2 classes ont en commun et que je peux surcharger :
        // ex : ils peuvent tous 2 grognés
    }
}

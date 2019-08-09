using System;

namespace Traveaux_pratique_c
{
    class Program
    {
        static void Main(string[] args)
        {

            // INTERPOLATION DE CHAINE GRACE AU $ {}

            Console.WriteLine($"");
            string NomDeLaVariable = "NomDeLaVariable";
            Console.WriteLine($" INTERPOLATION DE CHAINE GRACE AU $ {NomDeLaVariable} ");
            Console.WriteLine($"");


            string name = "jeremie";
            string lastname = "pichot";
            Console.WriteLine($"Bonjour {name}");


            name = "antoine";
            Console.WriteLine($" Bonjour {name}");
            Console.WriteLine("Bonjour" + name);

            Console.WriteLine($"Sait tu que ton nom : {lastname.ToUpper()} contient {lastname.Length} caractères.");


            // METHODE Trim() / TrimStart() / TrimEnd()   => Rogner
            Console.WriteLine($"");
            Console.WriteLine($" METHODE Trim() / TrimStart() / TrimEnd()   => Rogner");


            string salutation = "   '     Bienvenue     '   ";
            Console.WriteLine(salutation);

            string trimingSalutation = salutation.Trim();
            Console.WriteLine(trimingSalutation);

            salutation = "     hello    ";
            Console.WriteLine($"[{salutation}]");
            Console.WriteLine($"[{salutation.TrimEnd()}]");
            Console.WriteLine($"[{salutation.TrimStart()}]");


            //METHODE  Replace
            Console.WriteLine($"");
            Console.WriteLine($" METHODE  Replace");
            
            string sayHello = "Bonjour world";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Bonjour", "Bienvenu");
            Console.WriteLine(sayHello);


            //METHODE  Contains
            Console.WriteLine($"");
            Console.WriteLine($" METHODE  Contains");

            string songLyrics1 = "Keep calme and heat cookees !!";
            Console.WriteLine(songLyrics1.Contains("calme"));
            Console.WriteLine(songLyrics1.Contains("fuck"));

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // rechercher le debut ou la fin de la chaine avec StartsWith() et EndWith()

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));

            // comparaison ordinal par defaut respectant la casse

            //METHODE  String.Equals / string.CompareTo / string.Equality
            Console.WriteLine($"");
            Console.WriteLine($" METHODE  Equals");

            string root = @"C:\users";
            string root2 = @"C:\Users";

            bool result = root.Equals(root2);
            Console.WriteLine($"Ordinal comparison: {root} and {root2} are {(result ? "equal." : "not equal.")}");

            result = root.Equals(root2, StringComparison.Ordinal);
            Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");

            Console.WriteLine($"Using == says that <{root}> and <{root2}> are {(root == root2 ? "equal" : "not equal")}");

            // comparaison ordinal par defaut ne respectant pas la casse

            //METHODE  String.Equals(sting,stringComparaison / string.CompareTo / string.Equality
            Console.WriteLine($"");
            Console.WriteLine($" METHODE  String.Equals ne respectant pas la casse :");

            string root3 = "hello";
            string root4 = "Hello";
            
            bool CompareRoot = root3.Equals(root4, StringComparison.Ordinal);
            bool resultIgnoreCase = root3.Equals(root4, StringComparison.OrdinalIgnoreCase);
            int compareRootInt = String.Compare(root3, root4, comparisonType: StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Ordinal comparison respectant la casse : {root3} and {root4} are {(CompareRoot ? "equal." : "not equal.")}");
            Console.WriteLine($"Ordinal comparaison ne respectant pas la casse : {root3} et {root4} are {(resultIgnoreCase ? "equal." : "not equal.")}");

            if(compareRootInt < 0)
                Console.WriteLine($"<{root3}> is less than <{root4}>");
            else if (compareRootInt >0)
                Console.WriteLine($"<{root3}> is greater than <{root4}>");
            else
                Console.WriteLine($"<{root3}> and <{root4}> are equivalent in order");

            //METHODE  Comparaison linguistiques
            Console.WriteLine($"");
            Console.WriteLine($" METHODE  Comparaison linguistiques :");

            string first = "Sie tanzen auf der Straße.";
            string second = "Sie tanzen auf der Strasse.";
            Console.WriteLine($"First sentence is <{first}>");
            Console.WriteLine($"Second sentence is <{second}>");
            bool isComparaisonLinguistique = string.Equals(first, second, StringComparison.InvariantCulture);
            Console.WriteLine($"les 2 variables : <{first}> et <{second}> sont elle egall ? {(isComparaisonLinguistique ? "oui" : "non")}");
            Console.WriteLine($"");



            string word = "coop";
            string words = "co-op";
            string other = "cop";

            showComparison(word, words);
            showComparison(word, other);
            showComparison(words, other);

            // Arrays
            // TYPE[] name; -> NULL
            // TYPE[] name = new TYPE[size];

            int[] integerArray = new int[5];

                integerArray[0] = 5;
                integerArray[1] = 6;
                integerArray[2] = integerArray[0] + integerArray[1];
                integerArray[3] = 56 + integerArray[1];

                Console.WriteLine(integerArray);
                Console.WriteLine(integerArray[0]);
                Console.WriteLine(integerArray[1]);
                Console.WriteLine(integerArray[2]);
                Console.WriteLine(integerArray[2] + 60);



    Console.ReadKey();

        }
        static void showComparison(string one, string two)
        {
            int compareLinguistic = String.Compare(one, two, StringComparison.InvariantCulture);
            int compareOrdinal = String.Compare(one, two, StringComparison.Ordinal);
            if (compareLinguistic < 0)
            {
                Console.WriteLine($"<{one}> is less than <{two}> using invariant culture");
            }
            else if (compareLinguistic > 0)
                Console.WriteLine($"<{one}> is greater than <{two}> using invariant culture");
            else
                Console.WriteLine($"<{one}> and <{two}> are equivalent in order using invariant culture");
            if (compareOrdinal < 0)
                Console.WriteLine($"<{one}> is less than <{two}> using ordinal comparison");
            else if (compareOrdinal > 0)
                Console.WriteLine($"<{one}> is greater than <{two}> using ordinal comparison");
            else
                Console.WriteLine($"<{one}> and <{two}> are equivalent in order using ordinal comparison");
        }
    }
}

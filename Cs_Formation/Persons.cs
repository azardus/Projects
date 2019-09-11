namespace Persons
{
    public class Person
    {
        public string name;

        // Equivalent à Rename(person, name);
        public void Rename(string name) 
        {
            this.name = name;
        }
    }

    public static class Program
    {
        // Equivalent à person.Rename(name)
        public static void Rename(Person person, string name)
        {
            person.name = name;
        }

        public static void Main()
        {
            Person person = new Person();
            Person person2 = new Person();

            person.Rename("Toto");
            // Equivalent à
            Rename(person, "Toto");

            person2.Rename("Titi");
            // Equivalent à
            Rename(person2, "Titi");
        }
    }
}
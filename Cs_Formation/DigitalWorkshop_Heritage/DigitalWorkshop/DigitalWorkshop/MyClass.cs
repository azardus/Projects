namespace DigitalWorkshop
{
    public class Dog
    {
        public string Name;

        public int Age;

        public int Height;

        public int Length;

        public int Color;

        private string Stomach;

        public void IncrementAge()
        {
            this.Age += 1;
            this.Height = this.Age * 2;
        }
    }
}

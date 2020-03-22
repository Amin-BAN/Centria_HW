namespace exercise_124
{
    public class Null
    {
        private string name;
        private int value;
        public Null(string name)
        {
            this.name = name;
            this.value = 0;
        }

        public void Increase(int number)
        {
            this.value += number;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
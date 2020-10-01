namespace CleanCode
{
    public class Pair
    {
        private string from;
        private string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            return from == ((Pair)obj).from 
                && to == ((Pair)obj).to;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstValue = new ComparablePair<int, double>(5, 2.3);
            var secondValue = new ComparablePair<int, double>(5, 5.4);
            Console.WriteLine("Result is " + firstValue.CompareTo(secondValue));
        }
    }
    public class Pair<S, T> 
    {
        public S FirstValue { get; private set; }
        public T SecondValue { get; private set;}
        public Pair(S firstValue, T secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }
    }
    public class ComparablePair<T, U> : IComparable<ComparablePair<T,U>>
    {
        public T FirstValue { get; private set;}
        public U SecondValue { get; private set;}
        public ComparablePair(T firstValue, U secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public int CompareTo(ComparablePair<T,U> other)
        {
            if (FirstValue.ToString() == other.FirstValue.ToString())
            {
                return string.Compare(SecondValue.ToString(), other.SecondValue.ToString());
            }
            return string.Compare(FirstValue.ToString(), other.FirstValue.ToString());
        }
    }

}
namespace _02_ClassInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter();

            Counter counter2 = new Counter();

            Console.WriteLine(Counter.Counter_value);

            Counter counter3 = new Counter();

            Console.WriteLine(Counter.Counter_value);
        }
    }
    class Counter
    {
        private static int counter_value;
        public static int Counter_value
        {
            get { return counter_value; }
            private set { counter_value = value; }
        }

        public Counter()
        {
            counter_value++;
        }
    }
}

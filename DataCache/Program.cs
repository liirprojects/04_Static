namespace DataCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cache.Add(1, "bug fixer");
            Cache.Add(2, "removing items");

            Console.WriteLine(Cache.Get(1));

            Cache.Clear();

            Console.WriteLine(Cache.Get(1));

            Console.ReadKey();
        }
    }
    public static class Cache
    {
        private static Dictionary<int, string> cache_keeper;
        static Cache()
        {
            cache_keeper = new Dictionary<int, string>();
        }

        public static void Add(int key, string value)
        {
            if(cache_keeper.ContainsKey(key))
            {
                Console.WriteLine("Cache dictionary already contains input key. Updating data.");
                cache_keeper[key] = value;
            }
            else
            {
                Console.WriteLine("Input data was added to cache dictionary");
                cache_keeper.Add(key, value);  
            }
        }

        public static string Get(int key)
        {
            if(cache_keeper.ContainsKey(key))
                return cache_keeper[key];

            return "No available value for an input key";
        }

        public static void Clear()
        {
            cache_keeper.Clear();
        }
    }
}

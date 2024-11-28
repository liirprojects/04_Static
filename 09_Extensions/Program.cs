namespace _09_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = StringExtensions.Reverse("potop");
            Console.WriteLine(result);

            if (StringExtensions.IsPalindrome("potop"))
            {
                Console.WriteLine("The word is palindrome");
            } 
            
            Console.ReadLine();
        }
    }
    public static class StringExtensions
    {
        public static string Reverse(string str_toreverse)
        {
            char[] string_array = str_toreverse.ToCharArray();

            char[] new_array = new char[string_array.Length];
          
            for (int i = 0; i < string_array.Length; i++)
            {
                new_array[i] = string_array[string_array.Length - 1 - i];
            }

            string reversedWord = new string(new_array);
            return reversedWord;
        }

        public static bool IsPalindrome(string input)
        {
            if(input == Reverse(input))
                return true;

            return false;
        }
    }
}

namespace _01_MathOperations
{
    internal class Program
    {
        // // Создание статического класса
        static void Main(string[] args)
        {
            double r = 5.2;
            double returnSquare = MathUtils.CalculateCircleArea(r);

            Console.WriteLine("Circle square if the radius is [{0}] equals [{1:F3}]", r, returnSquare);

            Console.ReadKey();
        }
    }
    public static class MathUtils
    {
        public const double Pi = 3.14;

        public static double CalculateCircleArea(double radius)
        {
            double square = Pi + Math.Pow(radius, 2);
            return square;
        }
    }
}

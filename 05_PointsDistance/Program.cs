namespace _05_PointsDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(3, 3);

            double d = PointFeatures.ReturnDistance(point1, point2);
            Console.WriteLine($"Distance between X:[{point1.X},{point1.Y}] Y:[{point2.X},{point2.Y}] = {d:F3}");


            Tuple<double, double> midValues = PointFeatures.ReturnMiddleLengh(point1, point2);
            Console.WriteLine("Mid values: X:{0} Y:{1}", midValues.Item1, midValues.Item2);

            Console.ReadLine();
        }
    }
    public class Point
    {
        private double x;
        public double X
        {
            get { return x; }
            private set { x = value; }
        }
        private double y;
        public double Y
        {
            get { return y; }
            private set { y = value; }
        }

        public Point(double par_x, double par_y)
        {
            this.x = par_x;
            this.y = par_y;
        }
    }
    public static class PointFeatures
    {
        public static double ReturnDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt((Math.Pow(point2.X - point1.X, 2)) + (Math.Pow(point2.Y - point1.Y, 2)));

            return distance;
        }

        public static Tuple<double, double> ReturnMiddleLengh(Point point1, Point point2)
        {
            double mid_x = (point1.X + point2.X) / 2;
            double mid_y = (point1.Y + point2.Y) / 2;

            return Tuple.Create(mid_x, mid_y);
        }
    }
}

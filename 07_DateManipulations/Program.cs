namespace _07_DateManipulations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool check_in = DateTimeUtils.IsWeekend(DateTime.Now);
            if (check_in is true)
                Console.WriteLine($"{DateTime.Now.ToShortDateString()} is weekend. -- {DateTime.Now.DayOfWeek}");
            else
                Console.WriteLine("Current date is not weekend");

            DateTime dateTime = new DateTime(2024, 11, 28);
            int count = DateTimeUtils.DaysBetween(dateTime, DateTime.Now.Date);
            Console.Write("Result : {0}", count);

            Console.ReadKey();
        }
    }
    public static class DateTimeUtils
    {
        public static bool IsWeekend(DateTime input_date)
        {

            if (input_date.DayOfWeek is DayOfWeek.Saturday ||
                input_date.DayOfWeek is DayOfWeek.Sunday)
            {
                return true;
            }

            return false;
        }

        public static int DaysBetween(DateTime start, DateTime end)
        {
            int countDays = Math.Abs((end - start).Days);

            return countDays;
        }
    }
}

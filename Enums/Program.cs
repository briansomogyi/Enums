namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek friday = DayOfWeek.Friday;
            Console.WriteLine(friday);

            int fridayAsInt = (int)friday;
            Console.WriteLine(fridayAsInt);

            DayOfWeek day = (DayOfWeek)100;
            Console.WriteLine(day);

            DayOfWeek weekend = DayOfWeek.Sunday | DayOfWeek.Saturday;
            Console.WriteLine(weekend);

            bool isPartOfWeekend = (weekend & DayOfWeek.Monday) == DayOfWeek.Monday;
            Console.WriteLine($"Monday is part of combo: {isPartOfWeekend}");

            bool isSaturdayPartOfWeekend = (weekend & DayOfWeek.Saturday) == DayOfWeek.Saturday;
            Console.WriteLine($"Saturday is part of combo: {isSaturdayPartOfWeekend}");

            Console.WriteLine("Enter a day of the week");
            string dayValue = Console.ReadLine();

            // Varianta 1
            bool canConvert = Enum.TryParse(typeof(DayOfWeek), dayValue, out object result);
            if (canConvert)
            {
                DayOfWeek converterDayOfWeek = (DayOfWeek)result;
                Console.WriteLine(converterDayOfWeek);
            }
            else
            {
                Console.WriteLine($"{dayValue} cannot represent a valid DayOfWeek");
            }

            // Varianta 2
            bool canConvert2 = Enum.TryParse(dayValue, out DayOfWeek resultDayOfWeek);
            if (canConvert2)
            {
                Console.WriteLine(resultDayOfWeek);
            }
            else
            {
                Console.WriteLine($"{dayValue} cannot represent a valid DayOfWeek");
            }
        }
    }
}
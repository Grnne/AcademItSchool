namespace NextDate
{
    internal class NextDate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате дд\\мм\\гггг");

            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine()!);

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine()!);

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine()!);

            int lastMonthDay = GetLastMonthDay(month, year);

            if (year < 0 || month < 1 || month > 12 || day < 1 || day > lastMonthDay)
            {
                Console.WriteLine("Дата введена неверно");
            }
            else
            {
                int nextDay = day + 1;
                int nextMonth = month;
                int nextYear = year;

                if (nextDay > lastMonthDay)
                {
                    nextMonth++;
                    nextDay = 1;
                }

                if (nextMonth > 12)
                {
                    nextYear++;
                    nextMonth = 1;
                }

                Console.WriteLine($"Следующая дата: {nextDay:D2}.{nextMonth:D2}.{nextYear:D4}г.");
            }
        }

        public static int GetLastMonthDay(int month, int year)
        {
            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    return 29;
                }

                return 28;
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            return 31;
        }

        public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }
}
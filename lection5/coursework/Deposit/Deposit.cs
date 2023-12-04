namespace Deposit
{
    internal class Deposit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада, годовую ставку(в процентах) и количество месяцев");

            Console.Write("Введите сумму вклада: ");
            decimal initialMoneyAmount = decimal.Parse(Console.ReadLine()!);

            Console.Write("Введите ставку: ");
            decimal interestRate = decimal.Parse(Console.ReadLine()!);

            Console.Write("Введите количество месяцев: ");
            int monthsAmount = int.Parse(Console.ReadLine()!);

            const int monthsInYearAmount = 12;
            const int hundredPercent = 100;

            decimal monthlyInterestRate = interestRate / monthsInYearAmount / hundredPercent;
            decimal resultMoneyAmount = initialMoneyAmount;

            for (int i = 0; i < monthsAmount; i++)
            {
                resultMoneyAmount += resultMoneyAmount * monthlyInterestRate;
            }

            resultMoneyAmount = Math.Round(resultMoneyAmount, 2, MidpointRounding.AwayFromZero);
            decimal profit = Math.Round(resultMoneyAmount - initialMoneyAmount, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"В итоге у вас будет: {resultMoneyAmount}; прибыль: {profit}");
        }
    }
}
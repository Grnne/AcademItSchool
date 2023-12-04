namespace OrderCost;

internal class OrderCost
{
    public const double DiscountForAmountOrCost = 0.05;
    public const double DiscountForAmountAndCost = 0.10;
    public const int DiscountAmountThreshold = 10;
    public const double DiscountCostThreshold = 1000;

    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество товаров");

        Console.Write("Введите количество первого товара: ");
        int product1Amount = int.Parse(Console.ReadLine()!);

        Console.Write("Введите цену первого товара: ");
        double product1Price = double.Parse(Console.ReadLine()!);

        Console.Write("Введите количество второго товара: ");
        int product2Amount = int.Parse(Console.ReadLine()!);

        Console.Write("Введите цену второго товара: ");
        double product2Price = double.Parse(Console.ReadLine()!);

        double orderCost = GetOrderCost(product1Amount, product1Price, product2Amount, product2Price);
        Console.WriteLine($"Цена заказа: {orderCost}");
    }

    public static double GetOrderCost(int product1Amount, double product1Price, int product2Amount, double product2Price)
    {
        int totalProductsAmount = product1Amount + product2Amount;
        double orderCost = product1Amount * product1Price + product2Amount * product2Price;

        if (totalProductsAmount >= DiscountAmountThreshold && orderCost >= DiscountCostThreshold)
        {
            return orderCost - orderCost * DiscountForAmountAndCost;
        }

        if (totalProductsAmount >= DiscountAmountThreshold || orderCost >= DiscountCostThreshold)
        {
            return orderCost - orderCost * DiscountForAmountOrCost;
        }

        return orderCost;
    }
}
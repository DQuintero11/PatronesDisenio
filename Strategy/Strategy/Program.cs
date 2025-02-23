using Strategy;

class Program
{
    static void Main()
    {
        decimal totalAmount = 100m; // Precio base

        // Aplicar sin descuento
        ShoppingCart cart = new ShoppingCart(new NoDiscountStrategy());
        Console.WriteLine($"Total sin descuento: ${cart.CalculateTotal(totalAmount)}");

        // Aplicar 10% de descuento
        cart.SetDiscountStrategy(new TenPercentDiscountStrategy());
        Console.WriteLine($"Total con 10% de descuento: ${cart.CalculateTotal(totalAmount)}");

        // Aplicar 20% de descuento
        cart.SetDiscountStrategy(new TwentyPercentDiscountStrategy());
        Console.WriteLine($"Total con 20% de descuento: ${cart.CalculateTotal(totalAmount)}");
    }
}

using State;

class Program
{
    static void Main()
    {
        VendingMachine vendingMachine = new VendingMachine();

        // Intentar presionar el botón sin insertar moneda
        vendingMachine.PressButton();

        // Insertar moneda
        vendingMachine.InsertCoin();

        // Intentar insertar otra moneda
        vendingMachine.InsertCoin();

        // Presionar botón para comprar
        vendingMachine.PressButton();

        // Intentar presionar el botón nuevamente
        vendingMachine.PressButton();
    }
}

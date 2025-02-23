using Observador;

class Program
{
    static void Main()
    {
        // Creamos el producto
        Product laptop = new Product("Laptop Gamer");

        // Creamos clientes y los suscribimos al producto
        Customer alice = new Customer("Alice");
        Customer bob = new Customer("Bob");

        laptop.AddObserver(alice);
        laptop.AddObserver(bob);

        // Se actualiza el estado del producto
        Console.WriteLine("➡️ Intentando actualizar el stock...");
        laptop.SetInStock(true);
    }
}

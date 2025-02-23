using Mediator;

class Program
{
    static void Main()
    {
        // Creamos el mediador
        IChatMediator chatMediator = new ChatMediator();

        // Creamos usuarios y los agregamos al chat
        User user1 = new ChatUser(chatMediator, "Alice");
        User user2 = new ChatUser(chatMediator, "Bob");
        User user3 = new ChatUser(chatMediator, "Charlie");

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        // Los usuarios envían mensajes
        user1.SendMessage("¡Hola a todos!");
        user2.SendMessage("¡Hola Alice!");
    }
}

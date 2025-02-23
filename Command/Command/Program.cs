// Seclass Program
using Command;
{
    static void Main()
    {
        // Creamos el receptor (TV)
        TV myTV = new TV();

        // Creamos los comandos
        ICommand turnOn = new TurnOnCommand(myTV);
        ICommand turnOff = new TurnOffCommand(myTV);

        // Creamos el invocador (control remoto)
        RemoteControl remote = new RemoteControl();

        // Asignamos el comando para encender
        remote.SetCommand(turnOn);
        Console.WriteLine("🔹 Presionando botón ENCENDER:");
        remote.PressButton();

        // Deshacer la acción
        Console.WriteLine("🔹 Presionando botón DESHACER:");
        remote.PressUndo();

        // Asignamos el comando para apagar
        remote.SetCommand(turnOff);
        Console.WriteLine("🔹 Presionando botón APAGAR:");
        remote.PressButton();

        // Deshacer la acción
        Console.WriteLine("🔹 Presionando botón DESHACER:");
        remote.PressUndo();
    }
}

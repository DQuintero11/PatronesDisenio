using Memento;

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        TextHistory history = new TextHistory();

        // Escribimos algo y guardamos
        editor.Type("Hola");
        history.Save(editor.Save());

        // Escribimos más texto y guardamos
        editor.Type(", mundo!");
        history.Save(editor.Save());

        Console.WriteLine($"📄 Texto actual: {editor.GetText()}"); // Hola, mundo!

        // Deshacer última acción
        editor.Restore(history.Undo());
        Console.WriteLine($"↩️ Deshacer: {editor.GetText()}"); // Hola

        // Deshacer otra vez
        editor.Restore(history.Undo());
        Console.WriteLine($"↩️ Deshacer: {editor.GetText()}"); // (Vacío)
    }
}

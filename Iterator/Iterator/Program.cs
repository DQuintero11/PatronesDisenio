using Iterator;

class Program
{
    static void Main()
    {
        // Creamos una playlist y agregamos canciones
        Playlist playlist = new Playlist();
        playlist.AddSong(new Song("Bohemian Rhapsody", "Queen"));
        playlist.AddSong(new Song("Imagine", "John Lennon"));
        playlist.AddSong(new Song("Hotel California", "Eagles"));

        // Obtenemos un iterador y recorremos la colección
        IIterator<Song> iterator = playlist.GetIterator();

        Console.WriteLine("🎵 Reproduciendo Playlist:");
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}

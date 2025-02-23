using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Playlist : IAggregate<Song>
    {
        private List<Song> _songs = new List<Song>();

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public IIterator<Song> GetIterator()
        {
            return new PlaylistIterator(this);
        }

        public List<Song> GetSongs()
        {
            return _songs;
        }
    }

}

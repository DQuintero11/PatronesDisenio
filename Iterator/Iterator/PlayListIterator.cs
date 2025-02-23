using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class PlaylistIterator : IIterator<Song>
    {
        private Playlist _playlist;
        private int _position = 0;

        public PlaylistIterator(Playlist playlist)
        {
            _playlist = playlist;
        }

        public bool HasNext()
        {
            return _position < _playlist.GetSongs().Count;
        }

        public Song Next()
        {
            return _playlist.GetSongs()[_position++];
        }
    }

}

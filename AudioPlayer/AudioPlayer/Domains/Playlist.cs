using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Playlist
    {
        private string Name;

        public List<Song> Songs { get; set; }

        public List<Artist> Artist { get; set; }

        public Playlist(string name, List<Song> songs)
        {
            this.Name = name;
            this.Songs = songs;
        }

        public void Add(List<Song> songs)
        {
            Songs = songs;
        }
        public Playlist(List<Artist> artist)
        {
            Artist = artist;
        }

    }
}

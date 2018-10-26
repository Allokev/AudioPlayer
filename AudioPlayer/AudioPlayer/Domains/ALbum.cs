using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class ALbum
    {
        
        public ALbum(Artist artist, List<Song> songs, string name = "Unnamed")
        {
            Artist = artist;
            Name = name;
            Songs = songs;
        }

        public string Name { get; set; }

        public List<Song> Songs { get; set; }

        public Artist Artist { get; set; }
    }

}

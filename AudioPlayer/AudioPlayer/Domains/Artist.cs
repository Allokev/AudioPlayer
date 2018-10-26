using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Artist
    {

        public string Name { get; set; }

        public ALbum[] Albums { get; set; }

        public List<Song> Songs { get; }

        public Artist(List<Song> songs, string name)
        {
            Name = name;
            this.Songs = songs;

        }
        public Artist(List<Song> songs)
        {
            Name = "Where is my name?";
            this.Songs = songs;
        }
        public Artist(string name)
        {
            this.Name = name;


        }
    }

}

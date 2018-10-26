using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Song
    {
        public Genres Genry { get; set; }

        public Artist Artist { get; set; }

        public string Lyrics { get; set; }

        public string Name { get; set; }

        public Song( string lyrics = null, string name = null, Artist artist = null, Genres gen = Genres.None)
        {
            Genry = gen;
            Artist = artist;
            Lyrics = lyrics;
            Name = name;
        }
                
        public void Deconstruct(out string lyrics, out string name, out Artist artist, Genres gen)
        {
            gen = Genry;
            artist = Artist;
            lyrics = Lyrics;
            name = Name;
        }
    }

    

}

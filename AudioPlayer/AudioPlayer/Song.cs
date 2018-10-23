using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Song
    {
        public string Name;
        public string Lyrics { get; set; }
        public Artist artistOfCurrentSOng;
        public Genre genre { get; set; }
        public int duration;
        
        public Song(string Name, string Lyrics)
        {
            this.Name = Name;
            Console.WriteLine(Name);
            this.Lyrics = Lyrics;
            Console.WriteLine(Lyrics);
            
        }

    }

}

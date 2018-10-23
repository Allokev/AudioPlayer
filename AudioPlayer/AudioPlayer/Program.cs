using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            
            var numberOfArtist = new Artist();   
            var SongInPlayList = new Playlist();
            //Console.WriteLine(Genre.genreOfSOng.metal);
            /*player.Volume = 100;
            player.VolumeMinus();
            player.VolumeMinus();
            player.VolumeMinus();

            Console.WriteLine(player.Volume);*/
            //Console.WriteLine(numberOfArtist.x1);
            // player.Play();


            //songsong.thisSong();
            PlaySong();
            Console.ReadLine();

        }
        private static void PlaySong()
        {
            var player = new AudioPlayer();
            List<Song> songs = new List<Song>();


            Song song1 = new Song("Hight way to hell", "It`s been so far...");
            //player.Add(songs);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioPlayer.Extentions;

namespace AudioPlayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            AudioPlayer player = new AudioPlayer();
            var artistName = new Artist("Nirvana");
            var artistName2 = new Artist("Five Finger Death Punch");
            var artistName3 = new Artist("League Of Legends");
            var artistName4 = new Artist("Hollywood Undead");

            Song song1 = new Song(name:"Smells Like Teen Spirit", lyrics: "When the lights out...", gen: Genres.Rock, artist: artistName);
            Song song2 = new Song(name: "Wrong side heaven", lyrics: "Arms wide open...", gen: Genres.Metal, artist: artistName2);
            Song song3 = new Song(name: "Rise", lyrics: "They will remember you...", gen: Genres.Rock, artist: artistName3);
            Song song4 = new Song(name: "We are", lyrics: "...we`ve made from broken glass", gen: Genres.Hip_Hop, artist: artistName4);
            
            var artist = new Artist(new List<Song>() { song1,song2, song3,song4 });
            
            //var album = new ALbum(artist, new List<Song>() { song1, song2 });
            player.Add(artist);
            //player.Add(album);
            player.Songs.Shuffle();
           
            
            player.Play(out var PlayingSongvar);
            


            Console.ReadLine();
                        
        }
        
    }
}

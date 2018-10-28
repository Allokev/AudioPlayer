using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AudioPlayer
{
    public class AudioPlayer
    {
                
        public Song PlayingSong;

        private bool loop = false;

        public List<Song> Songs { get; set; }
                
        public bool sucessStart, sucessStop, Locked, IsPlaying = false;

        public AudioPlayer()
        {
            Songs = new List<Song>();
        }

        public void VolumePlus()
        {
            Volume = Volume + 1;
        }
        public void VolumeMinus()
        {
            Volume = Volume - 1;
        }
        private int _volume;
        public int Volume
        {

            get { return _volume; }
            set
            {
                if (value < 0) _volume = 0;
                else if (value > 100) _volume = 100;
                else _volume = value;
            }
        }
        public void Add(Artist artist)
        {
            Songs.AddRange(artist.Songs);
            
        }
        public void Add(params Song[] songs)
        {
            Songs.AddRange(songs);
        }

        public void Add(ALbum album)
        {
            Songs.AddRange(album.Songs);
        }

        public void Add(Playlist playList)
        {
            Songs.AddRange(playList.Songs);
        }
        public void Play(out Song PlayingSongvar)
        {
            PlayingSongvar = PlayingSong;

            for (var i = 0; i<Songs.Count;i++)
            {
                PlayingSong = Songs[i];

                Console.WriteLine($"Band : {PlayingSong.Artist.Name}\nSong : {Extentions.ExMeth.CutName(PlayingSong.Name)}\nLyrics : {PlayingSong.Lyrics}\nGenre: {PlayingSong.Genry}");
                Console.WriteLine(new string('*', 30));
                Thread.Sleep(5000);
                Console.Clear();

            }
            
        }
        public void Stop()
        {
            if (sucessStop == true) sucessStop = true;
            if (Locked == false) IsPlaying = false;
        }
        public void Lock()
        {
            Locked = true;
        }
        public void Unlock()
        {
            Locked = true;
        }

    }

}

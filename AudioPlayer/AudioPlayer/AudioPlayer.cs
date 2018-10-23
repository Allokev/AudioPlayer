using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class AudioPlayer
    {
        Artist objectArtist = new Artist();
        Song PlayingSong;
        ALbum objectAlbum = new ALbum();
        Playlist objectPlaylist = new Playlist();
        public bool sucessStart, sucessStop, Locked, isPlaying;
        public List<Song> songs = new List<Song>();


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
        public void Add(params Song[] song)
        {
            songs = song.ToList();
        }
        public void Add(Artist artist)
        {
            songs = artist.song;
        }

        public void Add(ALbum album)
        {
            songs = album.song;
        }
        public void Add(Playlist playlist)
        {
            songs = playlist.song;
        }
        public void Play()
        {
            if (sucessStart == true)
                sucessStart = true;
            if (Locked == false)
            {
                isPlaying = true;
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(PlayingSong.Lyrics);
                }

            }

        }
        public void Stop()
        {
            if (sucessStop == true) sucessStop = true;
            if (Locked == false) isPlaying = false;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer.Extentions
{
    public static class ExMeth
    {
        public static void Shuffle(this List<Song> songs)
        {
            var rnd = new Random();

            for (var i = songs.Count; i > 0; i--)
            {
                var smt = rnd.Next(i);

                songs.Add(songs[smt]);

                songs.RemoveAt(smt);
            }
        }

        //public static List<Song> Sorting(this List<Song> songs)
        //{

        //}

        public static string CutName(this string name, int number)
        {
            if (name.Length > 6)
            {
                
                return name.Substring(0,number).Replace(" ", "")+"...";
            }
            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    [Flags]
    public enum Genres
    {
        None = 0,
        Rock = 1,
        Rap = 2,
        Metal = 4,
        Hip_Hop = 8
    }
}

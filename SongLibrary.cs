using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSorterWithLinq
{
    class SongLibrary
    {
        public string Name { get; set; }
        private List<Song> songs = new List<Song>();  

        public SongLibrary(string name)
        {
            Name = name;
        }

        public void AddSong(Song newSong)
        {
            songs.Add(newSong);
        }
    }
}

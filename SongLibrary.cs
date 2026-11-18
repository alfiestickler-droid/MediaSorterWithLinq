using System;
using System.Collections.Generic;
using System.Text;
using MediaSorterWithLinq;

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

        public void ViewAllSongs()
        {
            Console.Clear();
            Console.WriteLine("----- All Songs -----\n");
            foreach(Song song in songs)
            {
                Console.WriteLine(song.SongInfo());
            }
        }
    }
}

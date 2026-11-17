using System;
using System.Collections.Generic;
using System.Text;

namespace MediaSorterWithLinq
{
    class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; set; }


        public Song(string title, string artist, string genre, int releaseYear, int rating)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            ReleaseYear = releaseYear;
            Rating = rating;
        }
    }
}

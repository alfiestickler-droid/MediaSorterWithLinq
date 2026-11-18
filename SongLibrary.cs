using System.Collections;

namespace MediaSorterWithLinq
{
    class SongLibrary : IEnumerable<Song>
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
            foreach (Song song in songs)
            {
                Console.WriteLine(song.SongInfo());
            }
        }

        public void OrganiseLibrary()
        {
            bool decending = false;

            Console.WriteLine("What catagory would you like to order your songs?");

            Console.WriteLine("1. Title");
            Console.WriteLine("2. Artist");
            Console.WriteLine("3. Genre");
            Console.WriteLine("4. Release Year");
            Console.WriteLine("5. Rating");

            Console.WriteLine("\nPlease pick an option using a number : ");
            string userOption = Console.ReadLine();

            while (userOption != "1" && userOption != "2" && userOption != "3" && userOption != "4" && userOption != "5")
            {
                Console.WriteLine("Sorry selection not valid, please enter either 1, 2, 3, 4 or 5 : ");
                userOption = Console.ReadLine();
            }

            Console.WriteLine("Would you like your order in acending or decending order (a/d)?");
            string acendOrDecend = Console.ReadLine();

            while (acendOrDecend?.Trim().ToLower() != "a" && acendOrDecend?.Trim().ToLower() != "d")
            {
                Console.WriteLine("Sorry selection not valid, please enter a for acending or d for decending.");
                acendOrDecend = Console.ReadLine();
            }

            if (acendOrDecend?.Trim().ToLower() == "d")
            {
                decending = true;
            }


            {
                songs = (userOption switch
                {
                    "1" => from song in songs orderby song.Title select song,
                    "2" => from song in songs orderby song.Artist select song,
                    "3" => from song in songs orderby song.Genre select song,
                    "4" => from song in songs orderby song.ReleaseYear select song,
                    "5" => from song in songs orderby song.Rating select song,

                }).ToList();
            }

            if (decending)
            {
                songs.Reverse();
            }

            ViewAllSongs();
        }

        //Allows Linq
        public IEnumerator<Song> GetEnumerator()
        {
            return songs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}

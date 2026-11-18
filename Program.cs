using MediaSorterWithLinq;

bool exit = false;

#region hardcoded songs

Song neonRain = new Song("Neon Rain on 5th", "The Midnight Static", "Electronic", 1984, 5);
Song velvetCrowns = new Song("Velvet Crowns", "Clara Vance", "Folk", 2018, 4);
Song rustAndHoney = new Song("Rust and Honey", "Silas Creed & The Dust", "Country", 1973, 5);
Song subwayGhosts = new Song("Subway Ghosts", "Concrete Echo", "Rock", 1981, 4);
Song solarisDrift = new Song("Solaris Drift", "Kaelen", "Electronic", 2022, 4);
Song paperPlanes = new Song("Paper Planes in Winter", "Juniper Lane", "Pop", 2020, 5);
Song ironcladHeart = new Song("Ironclad Heart", "Vulture's Peak", "Metal", 1988, 5);
Song midnightMontmartre = new Song("Midnight in Montmartre", "Henri Beaumont Trio", "Jazz", 1962, 5);
Song staticKiss = new Song("Static Kiss", "The Glass Violets", "Rock", 1993, 4);
Song goldDustFever = new Song("Gold Dust Fever", "Caleb Boone", "Country", 1977, 4);
Song chromeHorizon = new Song("Chrome Horizon", "Vector 9", "Electronic", 2025, 4);
Song sugarcoatTruth = new Song("Sugarcoat the Truth", "Maya Lin", "Soul", 2016, 5);
Song backseatConfessions = new Song("Backseat Confessions", "The Stray Cats of Soho", "Rock", 1996, 4);
Song echoesOfThePier = new Song("Echoes of the Pier", "Harbor Lights", "Rock", 1979, 4);
Song crownOfThorns = new Song("Crown of Thorns & Wire", "Malakor", "Metal", 2011, 5);
Song concreteJungle = new Song("Concrete Jungle Lullaby", "DJ Verse & Lyric", "Hip-Hop", 1994, 5);
Song bitterAlmondTea = new Song("Bitter Almond Tea", "Evelyn Thorne", "Pop", 2014, 4);
Song acceleratePulse = new Song("Accelerate the Pulse", "Hyperion", "Electronic", 2005, 4);
Song brokenCompass = new Song("Broken Compass", "The Wayward Sons", "Folk", 1971, 5);
Song electricFlamingo = new Song("Electric Flamingo", "Disco Mirage", "Pop", 2019, 4);
Song glassCages = new Song("Glass Cages", "The Hollow Choir", "Rock", 2003, 4);
Song saffronSkies = new Song("Saffron Skies", "Amina Rao", "Folk", 2021, 5);
Song noBrakes = new Song("No Brakes on the 405", "Skidmark", "Rock", 1998, 4);
Song whispersInTheIvy = new Song("Whispers in the Ivy", "Julian Cross", "Classical", 2012, 4);
Song moonlightBayou = new Song("Moonlight Over Bayou", "Thibodeaux Brothers", "Blues", 1968, 5);
Song pixelatedTears = new Song("Pixelated Tears", "BitCrush", "Electronic", 2015, 4);
Song feverDreamin = new Song("Fever Dreamin'", "Lola & The Velvetines", "Soul", 1970, 5);
Song gravityWell = new Song("Gravity Well", "Astral Nomad", "Rock", 1975, 5);
Song cityOfAsh = new Song("City of Ash", "Blackout Protocol", "Metal", 2023, 4);
Song lastTrainBrighton = new Song("Last Train to Brighton", "Oliver Finch", "Folk", 2026, 4);

SongLibrary mainLibrary = new SongLibrary("Main Library");

mainLibrary.AddSong(neonRain);
mainLibrary.AddSong(velvetCrowns);
mainLibrary.AddSong(rustAndHoney);
mainLibrary.AddSong(subwayGhosts);
mainLibrary.AddSong(solarisDrift);
mainLibrary.AddSong(paperPlanes);
mainLibrary.AddSong(ironcladHeart);
mainLibrary.AddSong(midnightMontmartre);
mainLibrary.AddSong(staticKiss);
mainLibrary.AddSong(goldDustFever);
mainLibrary.AddSong(chromeHorizon);
mainLibrary.AddSong(sugarcoatTruth);
mainLibrary.AddSong(backseatConfessions);
mainLibrary.AddSong(echoesOfThePier);
mainLibrary.AddSong(crownOfThorns);
mainLibrary.AddSong(concreteJungle);
mainLibrary.AddSong(bitterAlmondTea);
mainLibrary.AddSong(acceleratePulse);
mainLibrary.AddSong(brokenCompass);
mainLibrary.AddSong(electricFlamingo);
mainLibrary.AddSong(glassCages);
mainLibrary.AddSong(saffronSkies);
mainLibrary.AddSong(noBrakes);
mainLibrary.AddSong(whispersInTheIvy);
mainLibrary.AddSong(moonlightBayou);
mainLibrary.AddSong(pixelatedTears);
mainLibrary.AddSong(feverDreamin);
mainLibrary.AddSong(gravityWell);
mainLibrary.AddSong(cityOfAsh);
mainLibrary.AddSong(lastTrainBrighton);

#endregion

#region Main

while (!exit)
{
    SongMenu();

}

#endregion

#region functions
void SongMenu()
{
    Console.Clear();
    Console.WriteLine("---------- Media Center ----------\n");
    Console.WriteLine("----- Songs Menu -----");

    Console.WriteLine("1. View All Songs");
    Console.WriteLine("2. Organise Songs");
    Console.WriteLine("3. View songs with filter");
    Console.WriteLine("4. Exit");

    Console.WriteLine("\nPlease pick an option using a number : ");
    string userOption = Console.ReadLine();

    while (userOption != "1" && userOption != "2" && userOption != "3" && userOption != "4")
    {
        Console.WriteLine("Sorry selection not valid, please enter either 1, 2, 3 or 4");
    }

    switch (userOption)
    {
        case "1":
            mainLibrary.ViewAllSongs();
            MenuOrExit();
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            exit = true;
            break;
    }
}

void MenuOrExit()
{
    Console.WriteLine("\nTo return to menu please type 'menu' or to exit please type 'exit'");
    string userOption = Console.ReadLine();
    userOption.ToLower().Trim();

    if (userOption == "exit")
    {
        exit = true;
    }
    else
    {
        while (userOption != "menu" && userOption != "exit")
        {
            Console.WriteLine("Sorry not a valid input, please enter menu to return to menu or exit to exit");
            userOption = Console.ReadLine();
        }

        if (userOption == "exit")
        {
            exit = true;
        }
    }
}


#endregion
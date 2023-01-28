namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

     class Program
    {
        static void Main()
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split("_").ToArray();
                string songType = command[0];
                string songName = command[1];
                string songTime = command[2];
                Song song = new Song(songType, songName, songTime);

                songs.Add(song);
                
            }

            
            string cmd = Console.ReadLine();
            if (cmd == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in  songs)
                {
                    if (song.TypeList == cmd)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                    
                
            }
            
        }

    }
     class Song
    {
        public string TypeList { get; set; }  
        public string Name { get; set; }  
        public string Time { get; set; }

        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
    }
}
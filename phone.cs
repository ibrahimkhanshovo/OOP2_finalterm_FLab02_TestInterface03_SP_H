
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace TestInterface3
    {
        class Phone : MusicFile, MusicPlayerInterface
        {
            private MusicFile[] musicFiles;
            private int musicFileCount;
            public int MusicFileCount
            {
                get { return musicFileCount; }
                set { musicFileCount = value; }
            }
            public Phone()
            {
                musicFiles = new MusicFile[500];
                musicFileCount = 0;
            }
            public Phone(string title, string artist, int yearOfRelease, int durationInSeconds) : base(title, artist, yearOfRelease, durationInSeconds)
            {
                musicFiles = new MusicFile[500];
                musicFileCount = 0;

            }
            public void switchs(bool currentMode)
            {
                bool start = true;
                bool stop = false;
                if (currentMode == true)
                {
                    Console.Write("Turn On the music player on the Phone!");
                }
                else
                {
                    Console.Write("Turn Off the music player on the Phone!");
                }
            }
            public void play(bool currentMode)
            {
                bool start = true;
                bool stop = false;
                if (currentMode == true)
                {
                    Console.WriteLine("The music player is playing in the Phone!");
                }
                else
                {
                    Console.WriteLine("The music player is not playing on the Phone!");
                }
            }
            public void setVolume(int loudnessLevel)
            {

                if (loudnessLevel >= 0)
                {
                    Console.WriteLine("The music player loudness level is: " + loudnessLevel);
                }
                else
                {
                    Console.WriteLine("The volume is now: ''0'' ");
                    Console.WriteLine("The music player loudness level is in lowest level that's why " + loudnessLevel + "considered as 0 level loudness.");
                }
            }
            public void retune(double frequencyLevel)
            {
                Console.WriteLine("The radio player current frequency is: " + frequencyLevel);
            }
            public void AddMusicFile(params MusicFile[] musicFiles)
            {
                foreach (var a in musicFiles)
                {
                    if (musicFileCount < 500)
                    {
                        this.musicFiles[musicFileCount++] = a;
                    }
                    else
                    {
                        Console.WriteLine("Cannot create an account:  " + a.Title);
                    }
                }
            }
            public void ShowAllMusicFile()
            {
                for (int i = 0; i < musicFileCount; i++)
                {
                    this.musicFiles[i].ShowInfo();

                }
            }
            public void playNext()
            {
                Console.WriteLine("The next music in the playlist.");
                for (int i = 1; i < musicFileCount; i++)
                {
                    this.musicFiles[i + 1].ShowInfo();
                    break;
                }
            }

            public void playPrevious()
            {
                Console.WriteLine("The previous music in the playlist.");
                for (int i = 0; i < musicFileCount; i++)
                {
                    this.musicFiles[i].ShowInfo();
                    break;
                }
            }

            public void changeChannel()
            {
                Console.WriteLine("Now changing the radio channel.");
            }

        }

    }
}
    }
}

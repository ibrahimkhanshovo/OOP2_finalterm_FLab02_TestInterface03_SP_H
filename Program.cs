
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace TestInterface3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("******************* About Music *******************");
                Phone music1 = new Phone("Hamari Adhuri Khahani", " Indian Band", 2019, 360);
                music1.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("******************* Change The Title *******************");
                music1.changeTitle("Hamari Adhuri Khahani");
                music1.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("******************* Switching to Call ********************");
                music1.switchs(true);
                Console.WriteLine();
                Console.WriteLine("******************* Music During Call *********************");
                music1.play(true);
                Console.WriteLine();
                Console.WriteLine("******************* Set Volume Call with Loudness to 10 *******************");
                music1.setVolume(10);


                Phone music2 = new Phone("Aurora Dreams", "EIDA", 2020, 380);
                Phone music3 = new Phone("Diary of Jane", "Breaking Benjamin", 2006, 400);
                Phone music4 = new Phone("Carnival of Rust", "Poets of Fall", 2017, 480);
                Phone list = new Phone();
                list.AddMusicFile(music1, music2, music3, music4);


                Console.WriteLine();
                Console.WriteLine("******************* Next Music *******************");
                list.playNext();
                Console.WriteLine();
                Console.WriteLine("******************* Previous Music *******************");
                list.playPrevious();
                Console.WriteLine();
                Console.WriteLine("******************* List of Music *******************");


                list.ShowAllMusicFile();

            }
        }
    }
}
    }
}

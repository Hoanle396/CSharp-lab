using System;
using System.Collections.Generic;

namespace OOP_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Song> list = new List<Song>();

            for ( int i = 0; i < num; i++ )
            {
                string[] data = Console.ReadLine().Split("_");
                list.Add(new Song(data[0], data[1], data[2]));
            }

            string type = Console.ReadLine();

            if( type == "all")
            {
                foreach ( Song song in list )
                {
                    Console.WriteLine(song.Name);
                }
            }
            else { 
               foreach ( Song song in list)
                {
                    if (song.Typelist==type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}

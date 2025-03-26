using System;
using System.Collections.Generic;

namespace VideoStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoStore = new VideoStore();
            videoStore.AddMovie("Dune");
            videoStore.AddMovie("No Time to Die");
            videoStore.AddMovie("Spider-Man: No Way Home");

            videoStore.ViewMovie("Dune");
            videoStore.ViewMovie("Dune");
            videoStore.ViewMovie("Spider-Man: No Way Home");

            videoStore.DisplayViewCounts();
        }
    }

    public class VideoStore
    {
        private Dictionary<string, int> movieViewCounts;

        public VideoStore()
        {
            movieViewCounts = new Dictionary<string, int>();
        }

        public void AddMovie(string movieName)
        {
            if (!movieViewCounts.ContainsKey(movieName))
            {
                movieViewCounts[movieName] = 0;
            }
        }

        public void ViewMovie(string movieName)
        {
            if (movieViewCounts.ContainsKey(movieName))
            {
                movieViewCounts[movieName]++;
            }
            else
            {
                Console.WriteLine($"Movie '{movieName}' not found in the store.");
            }
        }

        public void DisplayViewCounts()
        {
            Console.WriteLine("Movie View Counts:");
            foreach (var movie in movieViewCounts)
            {
                Console.WriteLine($"{movie.Key}: {movie.Value} views");
            }
        }
    }
}
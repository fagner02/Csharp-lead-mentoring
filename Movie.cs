using System;
using System.Collections.Generic;

namespace MovieClass {
    class Movie {
        public string title;
        public string genre;
        public int rating;
        public DateTime releaseDate = new DateTime(2000, 1, 1);
        public string director;
        public List<string> actors = new List<string>();
        public List<string> characters = new List<string>();
        public string plot;
        public TimeSpan duration = new TimeSpan(1,1, 0);

        public void print(){
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Rating: " + rating);
            Console.WriteLine("Release date: " + releaseDate.ToShortDateString());
            Console.WriteLine("Director: " + director);
            Console.WriteLine("Actors: ");
            foreach (string actor in actors) {
                Console.WriteLine('\t'+actor);
            }
            Console.WriteLine("Plot: " + plot);
            Console.WriteLine("Duration: " + duration.TotalMinutes + " minutes");
            //Console.WriteLine("Duration: " + duration.Hours +"h "+ duration.Minutes+"min");
        }

        public Movie(){}
        public Movie(string title, string genre, int rating, DateTime releaseDate, string director, List<string> actors, string plot, TimeSpan duration) {
            this.title = title;
            this.genre = genre;
            this.rating = rating;
            this.releaseDate = releaseDate;
            this.director = director;
            this.actors = actors;
            this.plot = plot;
            this.duration = duration;
        }
    }
}
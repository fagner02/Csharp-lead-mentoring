using System;
using System.Collections.Generic;
using MovieClass;

namespace ArchiveClass {
    class Archive {
        public List<Movie> movies = new List<Movie>();
        public List<Movie> deactiveMovies = new List<Movie>();
        
        public Archive(List<Movie> movies) {
            this.movies = movies;
        }

        public void addMovie() {
            Movie temp = new Movie();
            Console.WriteLine("Enter the name of the movie: ");
            temp.title = Console.ReadLine();
            Console.WriteLine("Enter the genre of the movie: ");
            temp.genre = Console.ReadLine();
            Console.WriteLine("Enter the rating of the movie: ");
            temp.rating = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the movie's date: year, month, day ");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            temp.releaseDate = new DateTime(year, month, day);
            Console.WriteLine("Enter the name of the director: ");
            temp.director = Console.ReadLine();
            string input = "";
            Console.WriteLine("Enter the actors name and when you're done enter \'done\'");
            while(input != "done") {
                //Console.WriteLine("Enter actor name: ");
                input = Console.ReadLine();
                if(input != "done") {
                    temp.actors.Add(input);
                }
            }
            Console.WriteLine("Enter the synopsis of the movie: ");
            temp.plot = Console.ReadLine();
            Console.WriteLine("Enter the movie's date: year, month, day ");
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            temp.duration = new TimeSpan(hour, min, 0);

            if(movies.Exists(x => x.title == temp.title)){
                return;
            }
            movies.Add(temp);
        }

        public void deactivateMovie() {
            string title = Console.ReadLine();
            Movie movie = movies[movies.FindIndex(x => x.title == title)];
            deactiveMovies.Add(movie);
            movies.Remove(movie);
        }

        public void printMovies() {
            foreach (Movie movie in movies) {
                movie.print();
            }
        }

        public void printDeactiveMovies() {
            foreach (Movie movie in deactiveMovies) {
                movie.print();
            }
        }

        public void printMovie(){
            Console.WriteLine("Enter the movie title: ");
            string title = Console.ReadLine();
            if(!movies.Exists(x => x.title == title)) {
                Console.WriteLine("Movie not found");
                return;
            }
            movies.Find(x => x.title == title).print();

        }
        public void modify() {
            Console.WriteLine("Enter the movie you wanna modify: ");
            string title = Console.ReadLine();
            if(!movies.Exists(x => x.title == title)) {
                Console.WriteLine("Movie not found");
                return;
            }
            Console.WriteLine("Enter the new values to modify or just hit enter to kee the old values: ");
            Movie movie = movies[movies.FindIndex(x => x.title == title)];
            Console.WriteLine("Enter the new title: ");
            string newTitle = Console.ReadLine();
            if(newTitle != ""){movie.title = newTitle;}
            Console.WriteLine("Enter the new genre: ");
            string newGenre = Console.ReadLine();
            if(newGenre != "")movie.genre = newGenre;
            Console.WriteLine("Enter the new rating: ");
            try{
                movie.rating = int.Parse(Console.ReadLine());
            }catch{}
            Console.WriteLine("Enter the new date: year, month, day ");
            try{int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            movie.releaseDate = new DateTime(year, month, day);}catch{}
            Console.WriteLine("Enter the new director: ");
            string newDirector = Console.ReadLine();
            if(newDirector != "")movie.director = newDirector;
            string input = "";
            Console.WriteLine("Enter the new actors name and when you're done enter \'done\'");
            while(input != "done") {
                if(input == ""){
                    break;
                }
                //Console.WriteLine("Enter actor name: ");
                input = Console.ReadLine();
                if(input != "done") {
                    movie.actors.Add(input);
                }
            }
            Console.WriteLine("Enter the new synopsis: ");
            string newPlot = Console.ReadLine();
            movie.plot = newPlot;
            Console.WriteLine("Enter the new duration: hour, min, sec ");
            try{int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            movie.duration = new TimeSpan(hour, min, 0);}catch{}
        }
    }
}
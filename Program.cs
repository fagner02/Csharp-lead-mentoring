using System;
using System.Collections.Generic;
using MovieClass;
using ArchiveClass;

namespace filmes {
    class Program {

        static List<Movie> movies = new List<Movie>() {
            new Movie("The Shawshank Redemption", "Adventure", 10, new DateTime(2000, 4, 5), "Frank Darabont", new List<string>{"Nicole Kidman"}, "Crime, Drama", new TimeSpan(2, 56, 0)),

            new Movie("Bulsula de ouro", "Adventure", 10, new DateTime(2000, 4, 5), "Frank Darabont", new List<string>{"Nicole Kidman"}, "Crime, Drama", new TimeSpan(2, 40, 0))
        };

        static void Main(string[] args) {
            Archive archive = new Archive(movies);
            string[] commands = {
                "add",
                "remove",
                "list-active",
                "list-deactive",
                "print-movie",
                "modify",
                "exit"
            };

            string cmd = "";
            while(cmd != "exit"){
                Console.WriteLine("Enter command");
                cmd = Console.ReadLine();
                if(cmd == "add") {
                    archive.addMovie();
                }
                if(cmd == "remove") {
                    archive.deactivateMovie();
                }
                if(cmd == "list-active") {
                    archive.printMovies();
                }
                if(cmd == "list-deactive") {
                    archive.printDeactiveMovies();
                }
                if(cmd == "print-movie") {
                    archive.printMovie();
                }
                if(cmd == "modify") {
                    archive.modify();
                }
            }

            return;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam_practice
{
    public class MovieManager
    {
        private List<Movie> movies = new List<Movie>();

        public void CreateMovie(int Id, string title, string director, decimal price)
        {
            try
            {
                var movie = new Movie(Id, title, director, price);
                movies.Add(movie);
                Console.WriteLine("Movie Added Successfully!.");
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }

           
        }

        public void UpdateMovie (int id, string title, string director, decimal price)
        {
            var movie = movies.Find(a=> a.MovieId == id);

            movie.Title = title;
            movie.Director = director;
            movie.RentalPrice = price;

            Console.WriteLine("Movie Update SuccessFully!");

            Console.ReadLine();
            Console.Clear();

        }

        public void GetAllMovies()
        {
            if(movies == null)
            {
                Console.WriteLine("Movie Not Available");
            }
            foreach(var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        public void DeleteMovie(int id)
        {
            var movie = movies.Find(a=> a.MovieId==id);
            movies.Remove(movie);
            Console.WriteLine("Movie Successfully Deleted!");
        }

        public decimal ValidatePrice()
        {
            decimal price;
            do
            {
                Console.WriteLine("Input Price Must be Positive value.");
            }
            while(!decimal.TryParse(Console.ReadLine(), out price) || price <= 0);
            return price;
        }
    }
}

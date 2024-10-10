using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exam_practice
{
    public class MovieRepository
    {
        private string connectstrings = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = MovieRentalManagement; Integrated Security = True; Trust Server Certificate=True";
       

        public void AddMovie(Movie movie)
        {
            using (var connection = new SqlConnection(connectstrings))
            {
                connection.Open();
                var query = connection.CreateCommand();
                query.CommandText = @"Insert Into Movie (Title, Director, RentalPrice)
                  Values(@Title,@Director,@rentalPrice)
                ";
                query.Parameters.AddWithValue("@Title", movie.Title);
                query.Parameters.AddWithValue("@Director", movie.Director);
                query.Parameters.AddWithValue("@RentalPrice", movie.RentalPrice);

                query.ExecuteNonQuery();

            }
        }

        public void ViewMovies()
        {
            using (var connection = new SqlConnection(connectstrings))
            {
                connection.Open();
                var query = connection.CreateCommand();
                query.CommandText = @"Select * From Movie";

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    var movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3));
                    Console.WriteLine(movie.ToString());

                }
            }
        }

        public void updateMovie(Movie movie)
        {
            using (var connection = new SqlConnection(connectstrings))
            {
                connection.Open();
                var query = connection.CreateCommand();
                query.CommandText = @"Update Movie Set Title= @Title, Director = @Director, RentalPrice= @RentalPrice WHERE Id= @MoviesId";

                query.Parameters.AddWithValue("@MoviesId",movie.MovieId);
                query.Parameters.AddWithValue("@Title", movie.Title);
                query.Parameters.AddWithValue("@Director", movie.Director);
                query.Parameters.AddWithValue("@RentalPrice", movie.RentalPrice);
                query.ExecuteNonQuery();
            }
        }

        public void DeleteMovie(int id)
        {
            using (var connection = new SqlConnection(connectstrings))
            {
                connection.Open();
                var query = connection.CreateCommand();
                query.CommandText = @"DELETE Movie Where Id = @id";

                 query.Parameters.AddWithValue("@id", id);

        query.ExecuteNonQuery();

            }


        }
    }
}

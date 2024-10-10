using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_practice
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public decimal RentalPrice { get; set; }

        public Movie (int movieId, string title, string director, decimal rentalPrice)
        {
            MovieId = movieId;
            Title = title;
            Director = director;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"Id:{MovieId}, Title:{Title}, Dirctor:{Director}, RentalPrice:{RentalPrice:c}";
        }
    }
}

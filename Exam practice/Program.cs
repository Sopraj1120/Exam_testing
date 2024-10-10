namespace Exam_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            MovieRepository repository = new MovieRepository();
            int option;

            do
            {
                Console.WriteLine("Movie Management System..");
                Console.WriteLine("1. AddMovie");
                Console.WriteLine("2. View Movies");
                Console.WriteLine("3. Update Movie");
                Console.WriteLine("4. Delete Movie");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an Option: ");

                if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
                {
                    Console.WriteLine("Invalid inpu please put Valid id!.");
                }

                switch (option)
                {
                    case 1:
                        AddMovie(repository); break;
                    case 2:
                        repository.ViewMovies();
                        break;
                    case 3:
                        UpdateMovie(repository); break;
                    case 4:
                        DeleteMovie(repository); break;
                    case 5:
                        Console.WriteLine("Exit This System!..");
                        break;
                }
            }
            while (option != 5);
        }

        static void AddMovie(MovieRepository repository)
        {
            //Console.Write("Enter Movie Id: ");
            //int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie Title: ");
            string Title = Console.ReadLine();

            Console.Write("Enter Director: ");
            string Director = Console.ReadLine();

           
            
          
            
                MovieManager movieManager = new MovieManager();
                var rentalPrice = movieManager.ValidatePrice();
            
          


            //decimal rentalPrice = movieManager.ValidatePrice();

            repository.AddMovie(new Movie(Title, Director, rentalPrice));
            Console.Clear();
        }

        static void UpdateMovie(MovieRepository repository)
        {
            Console.Write("Enter Movie New Id: ");
            int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie New Title: ");
            string Title = Console.ReadLine();

            Console.Write("Enter New Director: ");
            string Director = Console.ReadLine();

            //decimal rentalPrice = movieManager.ValidatePrice();
            MovieManager movieManager = new MovieManager();
            var rentalPrice = movieManager.ValidatePrice();

            repository.updateMovie(new Movie(Title,Director,rentalPrice));

            Console.Clear();
        }

        static void DeleteMovie(MovieRepository repository)
        {
            Console.Write("Enter movie Id: ");
            int Id = int.Parse(Console.ReadLine());

            repository.DeleteMovie(Id);
            Console.Clear();
        }
    }
}

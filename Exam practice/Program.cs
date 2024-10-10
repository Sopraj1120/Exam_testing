namespace Exam_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager();
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
                        AddMovie(movieManager); break;
                    case 2:
                        movieManager.GetAllMovies();
                        break;
                    case 3:
                        UpdateMovie(movieManager); break;
                    case 4:
                        DeleteMovie(movieManager); break;
                    case 5:
                        Console.WriteLine("Exit This System!..");
                        break;
                }
            }
            while (option != 5);
        }

        static void AddMovie(MovieManager movieManager)
        {
            Console.Write("Enter Movie Id: ");
            int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie Title: ");
            string Title = Console.ReadLine();

            Console.Write("Enter Director: ");
            string Director = Console.ReadLine();

            decimal rentalPrice = movieManager.ValidatePrice();

            movieManager.CreateMovie(Id, Title, Director, rentalPrice);
            Console.Clear();
        }

        static void UpdateMovie(MovieManager movieManager)
        {
            Console.Write("Enter Movie New Id: ");
            int Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Movie New Title: ");
            string Title = Console.ReadLine();

            Console.Write("Enter New Director: ");
            string Director = Console.ReadLine();

            decimal rentalPrice = movieManager.ValidatePrice();

            movieManager.UpdateMovie(Id, Title, Director, rentalPrice);
            Console.Clear();
        }

        static void DeleteMovie(MovieManager movieManager)
        {
            Console.Write("Enter movie Id: ");
            int Id = int.Parse(Console.ReadLine());

            movieManager.DeleteMovie(Id);
            Console.Clear();
        }
    }
}

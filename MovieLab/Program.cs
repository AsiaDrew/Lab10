
using MovieLab;
List<Movie> movieList = new List<Movie> {
new Movie("Toy Story", "Animated"),
new Movie("A Goofy Movie", "Animated"),
new Movie("Basket Case", "Horror"),
new Movie("Dead Alive", "Horror"),
new Movie("My Bestfriends Girl", "Comedy"),
new Movie("Shallow Hal", "Comedy"),
new Movie("Hottub Time Machine", "Comedy"),
new Movie("The Notebook", "Drama"),
new Movie("Four Brothers", "Drama"),
new Movie("Blow", "Drama"),
};
bool goAgain = true;
Console.WriteLine("Welcome to the Movie List Application!\n");
while (goAgain)
{
    Console.Write("Please pick a genre: \nHorror, Animated, Drama, or Comedy: ");
    string userInput = Console.ReadLine().ToLower().Trim();
    List<Movie> movies = movieList.Where(x => x.Category.ToLower().Trim() == userInput).ToList();
    if (movies.Count == 0)
    {
        Console.WriteLine("We dont have that genre.");
    }
    else
    {
        foreach (Movie m in movies)
        {
            Console.WriteLine($"\n{m.Title}");
        }
    }
    while (true)
    {
        Console.WriteLine("\nWould you like to pick another category? Please enter y/n");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Okay, see you next time!");
            goAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("invalid input..");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    internal class Movie
    {
       public string title { get; set; }
		public string category { get; set; }

		public Movie(string titles, string categories)
		{
			this.title = titles;
			this.category = categories;
		}

		public void MovieList(List<Movie> movies, string category)
		{

            Console.WriteLine();
            Console.WriteLine($"You picked {category}!");
            Console.WriteLine();
			Console.WriteLine($"List of {category} movies are:");
			Console.WriteLine(" == == == == == == == ==  ");


			for (int i = 0; i <= movies.Count - 1; i++)
			{
				if (category == "Animated")
				{
					if (movies[i].category == category)
					{
						Console.WriteLine(movies[i].title);
					}
				}
				else if (category == "Horror")
				{
					if (movies[i].category == "Horror")
					{
						Console.WriteLine(movies[i].title);
					}
				}
				else if (category == "Comedy")
				{
					if (movies[i].category == "Comedy")
					{
						Console.WriteLine(movies[i].title);
					}
				}
				else if (category == "Drama")
				{
					if (movies[i].category == "Drama")
					{
						Console.WriteLine(movies[i].title);
					}
				}
				else
				{
                    Console.WriteLine();
					Console.WriteLine("Sorry, we dont have that here.");
					break;
				}
			}
		}
	}
}
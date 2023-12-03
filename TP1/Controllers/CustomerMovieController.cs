using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
	public class CustomerMovieController : Controller
	{
		public IActionResult Index()
		{
			List<Movie>movies = new List<Movie>()
			{
			new Movie{Name="movie 2"},
			new Movie{Name="movie 3"},
			};

			Customer customer = new Customer()
			{
				Id = 1,
				Name = "cyrine"
			};

			CustomerMovieVM viewModel = new CustomerMovieVM(customer, movies);
			return View(viewModel);
		}
	}
}

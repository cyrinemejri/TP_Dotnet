using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			Movie movie = new Movie()
			{
				Name = "movie 1"
			};
			List<Movie> movies = new List<Movie>()
			{
			new Movie{Name="movie 2"},
			new Movie{Name="movie 3"},
			};
			return View(movies);
		}
		[Route("Movie/released/{month}/{year}")]
		public IActionResult ByRelease(int Month ,int Year)
		{
			return Content("year:"+Year+"Month:"+Month);
		}
	}
}

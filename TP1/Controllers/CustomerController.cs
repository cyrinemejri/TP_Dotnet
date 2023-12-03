using Microsoft.AspNetCore.Mvc;
using TP1.Models;

namespace TP1.Controllers
{
	public class CustomerController : Controller
	{
		public List<Customer> customers = new List<Customer>()
		{
			new Customer() { Id = 1,Name="cyrine"},
			new Customer() { Id = 2,Name="sarra"},

		};
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Details(int id) {

			Customer c=customers.Find(x => x.Id == id);
			return View(c);

		}
	}
}

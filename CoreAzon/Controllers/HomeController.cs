using CoreAzon.Models;
using CoreAzon.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAzon.Controllers
{

    public class HomeController : Controller
    {
        //[HttpGet]

        [Route("")]
        public IActionResult IndexWithForm()
        {
            return View("IndexWithForm");
        }


        //[HttpPost]
        public IActionResult Index(Contact contact)
        {

            Customer customer = new Customer()
            {
                Id = 2,
                CustomerName = "The Company"
            };

            HomeIndexViewModel vm = new HomeIndexViewModel()
            {
                Contact = contact,
                Customer = customer
            };

            return View(vm);
        }
    }
}

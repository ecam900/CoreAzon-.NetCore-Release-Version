﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAzon.Controllers
{

    public class MemberHomeController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstantFest_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstantFest_2.Controllers
{
    public class BackOfficeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Title = "BackOffice";
            model.Text = "Welcome in the BackOffice Page";

            return View(model);
        }

    }
}
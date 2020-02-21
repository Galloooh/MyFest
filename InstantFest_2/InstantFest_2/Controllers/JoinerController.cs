using InstantFest_2.Models;
using InstantFest_2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantFest_2.Controllers
{
    public class JoinerController : Controller
    {
        [HttpGet]
        public ActionResult Profile(int id)
        {

            var utenteLoggato = Version["utenteLoggato"];
            if (utenteLoggato == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var model = new JoinerModel();
            model.Title = "Joiner Page";
            model.Text = "Welcome in joiner page";
            model.User = (User)utenteLoggato;
            //faccio un controllo per evitare che un utente veda il profilo 
            //di un altro
            if (model.User.Id != id)
            {
                return RedirectToAction("Profile", "Reserved", new { model.User.Id });
            }

            return View(model);
        }

    }

}

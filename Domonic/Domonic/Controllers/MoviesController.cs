using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domonic.Models;

namespace Domonic.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Rented(IList<string> movies)
        {
            return View(movies);
        }

        [HttpGet]
        public ActionResult ToRent()
        {
            var model = new MovieModel
            {
                AvailableMovies = AvailableMovies()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult ToRent(MovieModel m)
        {
            if (ModelState.IsValid)
            {
                return View("Rented", m.SelectedMovies);
            }
            m.AvailableMovies = AvailableMovies();

            return View(m);
        }


        //generate the list of movies I am going to put up for rent
        private IList<SelectListItem> AvailableMovies()
        {
            return new List<SelectListItem>
            {
            new SelectListItem { Value = "GhostBusters", Text = "GhostBusters" },
            new SelectListItem { Value = "Raising Arizona", Text = "Raising Arizona" },
            new SelectListItem { Value = "Charlie and The Chocolate Factory", Text = "Charlie and The Chocolate Factory" },
            new SelectListItem { Value = "Batman Begins", Text = "Batman Begins" },
            new SelectListItem { Value = "Apocalypse Now", Text = "Apocalypse Now" },
            new SelectListItem { Value = "Back To The Future", Text = "Back To The Future" },
            new SelectListItem { Value = "John Wick", Text = "John Wick" },
            new SelectListItem { Value = "Star Wars: Return of The Jedi", Text = "Star Wars: Return of The Jedi" },
            new SelectListItem { Value = "Avengers: Infinity War", Text = "Avengers: Infinity War" },
            new SelectListItem { Value = "Bill and Ted's Excellent Adventure", Text = "Bill and Ted's Excellent Adventure" }
        };
        

        }
    
    }
    
}
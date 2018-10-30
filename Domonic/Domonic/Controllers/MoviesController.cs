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
        // GET: Movies
        public ActionResult ToRent()
        {        
            return View();
        }

        //generate the list of movies I am going to put up for rent
        private void createMovies()
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie { Id = 1, Name = "GhostBusters" });
            movies.Add(new Movie { Id = 2, Name = "Raising Arizona" });
            movies.Add(new Movie { Id = 3, Name = "Charlie and The Chocolate Factory" });
            movies.Add(new Movie { Id = 4, Name = "Batman Begins" });
            movies.Add(new Movie { Id = 5, Name = "Apocalypse Now" });
            movies.Add(new Movie { Id = 6, Name = "Back To The Future" });
            movies.Add(new Movie { Id = 7, Name = "John Wick" });
            movies.Add(new Movie { Id = 8, Name = "Star Wars: Return of The Jedi" });
            movies.Add(new Movie { Id = 9, Name = "Avengers: Infinity War" });
            movies.Add(new Movie { Id = 10, Name = "Bill and Ted's Excellent Adventure" });

          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domonic.Models
{
    public class MovieModel
    {
        public IList<string> SelectedMovies { get; set; }

        public IList<SelectListItem> AvailableMovies { get; set; }

        public MovieModel()
        {
            SelectedMovies = new List<string>();
            AvailableMovies = new List<SelectListItem>();
        }
           
    }
}
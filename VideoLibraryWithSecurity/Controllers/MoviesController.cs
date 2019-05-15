﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VideoLibraryWithSecurity.Models;

namespace VideoLibraryWithSecurity.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        //Action result is the base class of all actions
        //change action result to view result
        public ActionResult Index()
        {

            var movies = GetMovies();

            return View(movies);      //  preferred method

        }


        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}
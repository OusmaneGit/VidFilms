﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidFilms.Models;
using VidFilms.ViewModels;

namespace VidFilms.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie= new Movie() {Name = "Shrek"};
            var viewResult = new ViewResult();
            var customers= new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel= new RandomMovieViewModel
            {
                Movie = movie,
                Customers=customers
            };
            //viewResult.ViewData.Model;
            return View(viewModel);
            //return Content("Hello Word");
        }
        //[Route("movies/released/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseYear(int year,int month)
        //{
        //    return Content(year+ "/" +month);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id= " + id);
        //}
        ////movies

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}
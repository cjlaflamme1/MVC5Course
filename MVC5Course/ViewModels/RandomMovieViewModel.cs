using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5Course.Models;

namespace MVC5Course.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
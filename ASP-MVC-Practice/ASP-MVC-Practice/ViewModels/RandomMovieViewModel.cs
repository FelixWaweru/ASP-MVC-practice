using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_MVC_Practice.Models;


namespace ASP_MVC_Practice.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
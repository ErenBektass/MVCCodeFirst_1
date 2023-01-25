using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.ViewModels
{
    public class MovieVM 
    {
        public List<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
        public List<Director> Directors { get; set; }
    }
}
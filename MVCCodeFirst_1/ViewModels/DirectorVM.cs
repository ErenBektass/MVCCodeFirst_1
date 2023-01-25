using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.ViewModels
{
    public class DirectorVM
    {
        public  List<Director> Directors { get; set; }
        public Director Director { get; set; }

    }
}
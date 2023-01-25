using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        //Relational Properties
        public virtual List<Movie> Movies { get; set; }

    }
}
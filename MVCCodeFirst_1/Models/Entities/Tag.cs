using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }


        //Relational Properties
        public  virtual List<MovieTag> MovieTags { get; set; }


    }
}
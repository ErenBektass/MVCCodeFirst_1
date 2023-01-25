using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class MovieTag : BaseEntity
    {
        public int MovieID { get; set; }
        public int TagID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Tag Tag { get; set; }


    }
}
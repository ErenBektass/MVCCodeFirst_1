using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public int? DirectorID { get; set; }
        public int? CategoryID { get; set; }



        //Relational Properties

        public virtual Director Director { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<MovieArtist> MovieArtists { get; set; }
        public  virtual List<MovieTag> MovieTags { get; set; }



    }
}
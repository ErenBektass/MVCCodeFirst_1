using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Entities
{
    public class MovieArtist : BaseEntity
    {
        public int MovieID { get; set; }
        public int ArtistID { get; set; }

        //Relational Properties
        public virtual Movie Movie { get; set; }
        public virtual Artist Artist { get; set; }


    }
}
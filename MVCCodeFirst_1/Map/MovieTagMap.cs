using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Map
{
    public class MovieTagMap:BaseMap<MovieTag>
    {
        public MovieTagMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.TagID,
                x.MovieID
            });
        }
    }
}
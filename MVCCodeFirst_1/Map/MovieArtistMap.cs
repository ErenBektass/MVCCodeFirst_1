using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Map
{
    public class MovieArtistMap:BaseMap<MovieArtist>
    {
        public MovieArtistMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ArtistID,
                x.MovieID
            });
        }
    }
}
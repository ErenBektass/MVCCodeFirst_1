using MVCCodeFirst_1.Map;
using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new MovieArtistMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new MovieTagMap());
            modelBuilder.Configurations.Add(new DirectorMap());
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTag> MovieTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<MovieArtist> MovieArtists { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
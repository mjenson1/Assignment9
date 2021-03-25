using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext(DbContextOptions<MovieListContext> options) : base(options) //this always has to be in there to connect to the DB
        {
            //stays empty
        }

        public DbSet<Movie> Movies { get; set; } // inside this class you are gonna store a data set of movies. a set is like a list. 

            
    }
}

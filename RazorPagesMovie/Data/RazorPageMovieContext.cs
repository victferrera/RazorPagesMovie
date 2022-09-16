using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPageMovieContext : DbContext
    {
        public RazorPageMovieContext(DbContextOptions<RazorPageMovieContext> opt) : base(opt){}

        public DbSet<Movie> Movie { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class HomeModel : PageModel
    {
        public RazorPageMovieContext _context;

        public HomeModel(RazorPageMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Movie> Movies { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Movies = await _context.Movie.ToListAsync();

            return Page();
        }
    }
}

using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class UpdateModel : PageModel
    {
        public RazorPageMovieContext _context;

        [BindProperty]
        public Movie Movie { get; set; }

        public UpdateModel(RazorPageMovieContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync([FromQuery]int id)
        {
            Movie = await GetMovieAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            _context.Movie.Update(Movie);
            await _context.SaveChangesAsync();

            return Redirect("/Home");
        }

        private async Task<Movie> GetMovieAsync(int id)
        {
            return await _context.Movie.FindAsync(id);
        }
    }
}

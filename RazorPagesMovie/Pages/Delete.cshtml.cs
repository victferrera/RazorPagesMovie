using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class DeleteModel : PageModel
    {
        public RazorPageMovieContext _context;

        [BindProperty]
        public Movie Movie { get; set; }

        public DeleteModel(RazorPageMovieContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync([FromQuery] int id)
        {
            Movie = await GetMovieAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Movie.Remove(Movie);
            await _context.SaveChangesAsync();

            return Redirect("/Home");
        }

        private async Task<Movie> GetMovieAsync(int id)
        {
            return await _context.Movie.FindAsync(id);
        }
    }
}

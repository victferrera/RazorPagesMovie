using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageMovieContext _context;

        public CreateModel(RazorPageMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var movie = _context.Add(new Movie());

            movie.CurrentValues.SetValues(Movie);
            await _context.SaveChangesAsync();

            return Redirect("/Home");
        }
    }
}

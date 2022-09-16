using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }
        public void OnGet()
        {
        }
    }
}

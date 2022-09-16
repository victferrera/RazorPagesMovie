using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class HomeModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}

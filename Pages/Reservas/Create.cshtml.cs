using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgenciaTurismo.Pages.Reservas
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Reserva Reserva { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            return RedirectToPage("Index");
        }
    }
}
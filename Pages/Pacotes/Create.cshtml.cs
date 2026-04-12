using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using AgenciaTurismo.Data;
namespace AgenciaTurismo.Pages.Pacotes
{
    public class CreateModel : PageModel
    {
        private readonly AgenciaContext _context;

        public CreateModel(AgenciaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PacoteTuristico Pacote { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Pacotes.Add(Pacote);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
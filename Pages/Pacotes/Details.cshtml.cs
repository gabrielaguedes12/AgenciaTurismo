using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using System.Linq;

namespace AgenciaTurismo.Pages.Pacotes
{
    public class DetailsModel : PageModel
    {
        private readonly AgenciaContext _context;

        public DetailsModel(AgenciaContext context)
        {
            _context = context;
        }

        public PacoteTuristico Pacote { get; set; }

        public IActionResult OnGet(int id)
        {
            Pacote = _context.Pacotes.FirstOrDefault(p => p.Id == id);

            if (Pacote == null)
                return NotFound();

            return Page();
        }
    }
}
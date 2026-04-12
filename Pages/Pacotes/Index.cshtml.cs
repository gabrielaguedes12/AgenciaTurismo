using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaTurismo.Pages.Pacotes
{
    public class IndexModel : PageModel
    {
        private readonly AgenciaContext _context;

        public IndexModel(AgenciaContext context)
        {
            _context = context;
        }

        public IList<PacoteTuristico> Pacotes { get; set; }

        public void OnGet()
        {
            Pacotes = _context.Pacotes.ToList();
        }
    }
}
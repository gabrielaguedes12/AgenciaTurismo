using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;

namespace AgenciaTurismo.Pages.Notes
{
    public class ViewNotesModel : PageModel
    {
        [BindProperty]
        public string Conteudo { get; set; }

        public string[] Arquivos { get; set; }

        public string ConteudoSelecionado { get; set; }

        public void OnGet()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            Arquivos = Directory.GetFiles(path).Select(f => Path.GetFileName(f)).ToArray();
        }

        public IActionResult OnPost()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            System.IO.File.WriteAllText(Path.Combine(path, "nota.txt"), Conteudo);

            return RedirectToPage();
        }

        public void OnGetRead(string nome)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files", nome);

            if (System.IO.File.Exists(path))
                ConteudoSelecionado = System.IO.File.ReadAllText(path);
        }
    }
}
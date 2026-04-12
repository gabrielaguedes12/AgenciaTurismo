using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Services;

namespace AgenciaTurismo.Pages
{
    public class DescontoModel : PageModel
    {
        [BindProperty]
        public decimal Preco { get; set; }

        public decimal PrecoComDesconto { get; set; }

        public void OnPost()
        {
            var service = new DescontoService();

            CalculateDelegate calc = service.AplicarDesconto;

            PrecoComDesconto = calc(Preco);
        }
    }
}
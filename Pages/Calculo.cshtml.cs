using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace AgenciaTurismo.Pages
{
    public class CalculoModel : PageModel
    {
        [BindProperty]
        public int Quantidade { get; set; }

        [BindProperty]
        public decimal Preco { get; set; }

        public decimal Total { get; set; }

        public void OnPost()
        {
            Func<int, decimal, decimal> calcular = (q, p) => q * p;

            Total = calcular(Quantidade, Preco);
        }
    }
}
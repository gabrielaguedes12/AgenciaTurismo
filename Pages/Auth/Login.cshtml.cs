using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgenciaTurismo.Pages.Auth
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Senha { get; set; }

        public IActionResult OnPost()
        {
            if (Usuario == "admin" && Senha == "123")
            {
                HttpContext.Session.SetString("User", Usuario);
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
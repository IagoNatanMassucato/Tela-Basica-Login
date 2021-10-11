using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MeuSistema.classes;

namespace MeuSistema.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
          ViewData["Logado"] = Login.Logado();
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MeuSistema.classes
{
    public class  Login
    {
       [Display(Name = "E-mail", Prompt = "E-mail")] 
       [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
       [Required(ErrorMessage = "Por favor, informe seu E-mai")]
       public string Email { get; set; }

       [Display(Name = "Senha", Prompt = "Senha")] 
       [DataType(DataType.Password)]
       [Required(ErrorMessage = "Por favor, informe sua Senha")]
       public string Senha { get; set; }

       [Display(Name = "Manter Conectado")]
       public bool Manter { get; set; }
       public bool Logado()
       {
           return ((Email == "admin@meusistema.com.br") && (Senha == "123456"));
       }
    }
}
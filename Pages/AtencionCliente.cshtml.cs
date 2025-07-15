using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWebFormularios.Pages
{
    public class AtencionClienteModel : PageModel
    {
        [BindProperty]
        public AtencionClienteInputModel Input { get; set; }

        // Este objeto almacenará los datos para un uso posterior.
        public static AtencionClienteInputModel DatosRecibidos { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DatosRecibidos = Input;

            
            SuccessMessage = "¡Formulario enviado con éxito!";

            return Page();
        }
    }

    public class AtencionClienteInputModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        public string Apellidos { get; set; }

        [Phone(ErrorMessage = "El formato del teléfono no es válido.")]
        [Display(Name = "Teléfono Celular")]
        public string TelefonoCelular { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un sexo.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un motivo.")]
        public string Motivo { get; set; }
    }
}
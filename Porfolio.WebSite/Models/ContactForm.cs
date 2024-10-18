using System.ComponentModel.DataAnnotations;

namespace Porfolio.WebSite.Models;

public class ContactForm
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no debe superar los 100 caracteres.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "El asunto es obligatorio.")]
    [StringLength(150, ErrorMessage = "El asunto no debe superar los 150 caracteres.")]
    public string? Subject { get; set; }

    [Required(ErrorMessage = "El mensaje es obligatorio.")]
    [StringLength(1000, ErrorMessage = "El mensaje no debe superar los 1000 caracteres.")]
    public string? Message { get; set; }

    public bool SendCopyToSelf { get; set; }
}

#pragma warning disable CS8618
using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MinLength(4, ErrorMessage = "El nombre debe tener al menos 4 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [MinLength(4, ErrorMessage = "El apellido debe tener al menos 4 caracteres.")]
    public string Apellido { get; set; }

    [Required(ErrorMessage = "La edad es obligatoria.")]
    [Range(1, int.MaxValue, ErrorMessage = "La edad debe ser un número positivo.")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
    public string Password { get; set; }
}

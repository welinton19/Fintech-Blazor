using System.ComponentModel.DataAnnotations;

namespace FintechBlazor.Services.Models;

public class CadastroRequest
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Cpf { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public DateOnly DataDeNascimento { get; set; }

    [Required]
    public string? Cidade { get; set; }

    [Required]
    public string? Logradouro { get; set; }

    [Required]
    public string? Cep { get; set; }

    [Required]
    public string? Estado { get; set; }


    [Required]
    public string? Password { get; set; }
    [Required]
    public string? ConfirmPassword { get; set; }

    [Required]
    public string? Phone { get; set; }

}

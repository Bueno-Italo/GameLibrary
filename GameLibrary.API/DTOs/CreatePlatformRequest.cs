using System.ComponentModel.DataAnnotations;

namespace GameLibrary.API.DTOs
{
    /// <summary>
    /// DTO - Classe simples que define quais dados a API aceita receber
    /// </summary>
    public class CreatePlatformRequest
    {
        [Required(ErrorMessage = "O nome da plataforma é obrigatório.")]
        public string Name { get; set; } = string.Empty;
    }
}

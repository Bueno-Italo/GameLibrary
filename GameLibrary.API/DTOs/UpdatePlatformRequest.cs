using System.ComponentModel.DataAnnotations;

namespace GameLibrary.API.DTOs
{
    public class UpdatePlatformRequest
    {
        [Required(ErrorMessage = "O nome da plataforma é obrigatório.")]
        public string Name { get; set; } = string.Empty;
    }
}
using GameLibrary.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace GameLibrary.API.DTOs
{
    public class CreateGameRequest
    {
        [Required(ErrorMessage = "O nome do jogo é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do jogo deve ter no máximo 100 caracteres")]
        public string Name { get; set; }

        [EnumDataType(typeof(GameType), ErrorMessage = "Tipo de jogo inválido")]
        public GameType Type { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O ID da plataforma é inválido")]
        public int PlatformId { get; set; }

        public string? Description { get; set; }
        public DateOnly? ReleaseDate { get; set; }
    }
}
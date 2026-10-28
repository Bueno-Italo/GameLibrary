using GameLibrary.Domain.Enums;

namespace GameLibrary.API.DTOs
{
    public class GameResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  GameType  Type { get; set; }
        public DateOnly? ReleaseDate { get; set; }
        public string PlatformName { get; set; }
    }
}
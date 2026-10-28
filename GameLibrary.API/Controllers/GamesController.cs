using GameLibrary.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGames()
        {
            var games = await _gameService.GetAllGamesAsync();
            var gameResponses = games.Select(g => new DTOs.GameResponse
            {
                Id = g.Id,
                Name = g.Name,
                Type = g.Type,
                ReleaseDate = g.ReleaseDate,
                PlatformName = g.Platform.Name
            });

            return Ok(gameResponses);
        }
    }
}
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
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

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(DTOs.GameResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public  async Task<IActionResult> GetGameById(int id)
        {
            var game = await _gameService.GetByIdAsync(id);
            if (game == null)
            {
                return NotFound("Jogo não encontrado");
            }

            return Ok(new DTOs.GameResponse
            {
                Id = game.Id,
                Name = game.Name,
                Type = game.Type,
                ReleaseDate = game.ReleaseDate,
                PlatformName = game.Platform.Name
            });
        }
    }
}
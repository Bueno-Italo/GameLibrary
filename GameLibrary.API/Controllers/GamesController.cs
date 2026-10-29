using GameLibrary.Application.Interfaces;
using GameLibrary.Application.Services;
using GameLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IPlatformService _platformService;
        public GamesController(IGameService gameService, IPlatformService platformService)
        {
            _gameService = gameService;
            _platformService = platformService;
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

        [HttpPost]
        [ProducesResponseType(typeof(DTOs.GameResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> CreateGame(DTOs.CreateGameRequest gameRequest)
        {
            var platform = await _platformService.GetPlatformByIdAsync(gameRequest.PlatformId);
            if (platform == null)
                return NotFound("Plataforma não encontrada");

            var game = new Game(
                gameRequest.Name,
                gameRequest.PlatformId,
                gameRequest.Type,
                gameRequest.Description,
                gameRequest.ReleaseDate
                );

            var createdGame = await _gameService.AddGameAsync(game);
            return CreatedAtAction(nameof(GetGameById), new
            {
                id = createdGame.Id
            }, new DTOs.GameResponse
            {
                Id = createdGame.Id,
                Name = createdGame.Name,
                Type = createdGame.Type,
                ReleaseDate = createdGame.ReleaseDate,
                PlatformName = platform.Name
            });
        }
    }
}
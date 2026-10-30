using GameLibrary.API.DTOs;
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

        [HttpPost]
        [ProducesResponseType(typeof(DTOs.GameResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> CreateGame(DTOs.CreateGameRequest gameRequest)
        {
            var game = new Game(
                gameRequest.Name,
                gameRequest.PlatformId,
                gameRequest.Type,
                gameRequest.Description,
                gameRequest.ReleaseDate
                );

            var createdGame = await _gameService.AddGameAsync(game);
            if(createdGame == null)
            {
                return NotFound("Plataforma não encontrada");
            }
            var gameWithPlatform = await _gameService.GetByIdAsync(createdGame.Id);

            if(gameWithPlatform == null)
            {
                return NotFound("Jogo não encontrado após a criação");
            }   

            return CreatedAtAction(nameof(GetGameById), new
            {
                id = createdGame.Id
            }, new DTOs.GameResponse
            {
                Id = createdGame.Id,
                Name = createdGame.Name,
                Type = createdGame.Type,
                ReleaseDate = createdGame.ReleaseDate,
                PlatformName = gameWithPlatform.Platform.Name
            });
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> UpdateGame(int id, DTOs.UpdateGameRequest updateGameRequest)
        {
            var updated = await _gameService.UpdateGameAsync(
                id,
                updateGameRequest.Name,
                updateGameRequest.PlatformId,
                updateGameRequest.Type,
                updateGameRequest.Description,
                updateGameRequest.ReleaseDate);

            if (!updated)
            {
                return NotFound("Jogo ou plataforma não encontrado");
            }
            return Ok();
        }
    }
}
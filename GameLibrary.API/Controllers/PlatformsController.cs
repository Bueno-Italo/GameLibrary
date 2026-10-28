using GameLibrary.API.DTOs;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformService _platformService;

        public PlatformsController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPlatforms()
        {
            var platforms = await _platformService.GetAllPlatformsAsync();
            return Ok(platforms);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Platform), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddPlatformAsync([FromBody] CreatePlatformRequest createPlatformRequest)
        {
            var platform = new Platform(createPlatformRequest.Name);
            var createdPlatform = await _platformService.AddPlatformAsync(platform);
            return StatusCode(StatusCodes.Status201Created, createdPlatform);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Platform), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPlatformById(int id)
        {
            var platform = await _platformService.GetPlatformByIdAsync(id);
            if (platform == null)
            {
                return NotFound("Plataforma não encontrada");
            }
            return Ok(platform);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Platform), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePlatform(int id, [FromBody] UpdatePlatformRequest updatePlatformRequest)
        {
            var platform = await _platformService.GetPlatformByIdAsync(id);
            if (platform == null)
            {
                return NotFound("Plataforma não encontrada");
            }

            platform.UpdateName(updatePlatformRequest.Name);
            var updatedPlatform = await _platformService.UpdatePlatformAsync(platform);
            return Ok(updatedPlatform);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePlatform(int id)
        {
            var deleted = await _platformService.DeletePlatformAsync(id);
            if (!deleted)
                return NotFound("Plataforma não encontrada");
            
            return NoContent();
        }
    }
}
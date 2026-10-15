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
        public async Task<IActionResult> AddPlatformAsync([FromBody] CreatePlatformRequest createPlatformRequest)
        {
            var platform = new Platform(createPlatformRequest.Name);
            var createdPlatform = await _platformService.AddPlatformAsync(platform);
            return StatusCode(201, createdPlatform);
        }
    }
}
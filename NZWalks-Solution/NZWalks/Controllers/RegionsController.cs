using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Repositories;

namespace NZWalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        public RegionsController(IRegionRepository _regionRepository)
        {
            this.regionRepository = _regionRepository;
        }
        [HttpGet]
        //[Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAll()
        {
            // Get Data From Database - Domain models
            var regionsDomain = await regionRepository.GetAllAsync();

            // Return DTOs
            return Ok(regionsDomain);
        }

    }
}

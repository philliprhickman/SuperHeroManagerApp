using Microsoft.AspNetCore.Mvc;
using SuperHero.Application.Interfaces.Services;
using SuperHero.Application.Models;

namespace SuperHero.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroesController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<IEnumerable<SuperHeroModel>> GetAll()
        {
            return await _superHeroService.GetAllAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<SuperHeroModel> GetById(int id)
        {
            var superHero = await _superHeroService.GetByIdAsync(id);

            return superHero;
        }

        [HttpPost]
        public async Task<SuperHeroModel> Create([FromBody] SuperHeroModel superHero)
        {
            var newSuperHero = await _superHeroService.CreateAsync(superHero);

            return newSuperHero;
        }

        [HttpPut]
        public async Task Update([FromBody] SuperHeroModel superHero)
        {
            await _superHeroService.UpdateAsync(superHero);
        }

        [HttpDelete("{id:int}")]
        public async Task Remove(int id)
        {
            await _superHeroService.RemoveAsync(id);
        }
    }
}

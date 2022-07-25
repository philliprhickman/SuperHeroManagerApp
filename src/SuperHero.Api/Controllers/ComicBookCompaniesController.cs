using Microsoft.AspNetCore.Mvc;
using SuperHero.Application.Interfaces.Services;
using SuperHero.Application.Models;

namespace SuperHero.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ComicBookCompaniesController : ControllerBase
{
    private readonly IComicBookCompanyService _comicBookCompanyService;

    public ComicBookCompaniesController(IComicBookCompanyService comicBookCompanyService)
    {
        _comicBookCompanyService = comicBookCompanyService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var companies = await _comicBookCompanyService.GetAllAsync();

        if (companies is null)
            return NotFound();

        return Ok(companies);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var company = await _comicBookCompanyService.GetByIdAsync(id);

        if (company is null)
            return NotFound();

        return Ok(company);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ComicBookCompanyModel comicBookCompanyModel)
    {
        var newCompany = await _comicBookCompanyService.CreateAsync(comicBookCompanyModel);

        if (newCompany is null)
            return NotFound();

        return Ok(newCompany);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ComicBookCompanyModel comicBookCompanyModel)
    {
        await _comicBookCompanyService.UpdateAsync(comicBookCompanyModel);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _comicBookCompanyService.RemoveAsync(id);

        return NoContent();
    }
}

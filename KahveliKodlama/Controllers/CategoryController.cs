using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{

    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet("getAllData")]
    public  IQueryable<Category> GetAllData()
    {
        var result =  _categoryService.GetAllQueryInc(x => x.Headings);

        return result;
    }

    [HttpGet("getAllDto")]
    public async Task<IActionResult> GetAllDto()
    {

        var result = await _categoryService.GetAllQuery.ToListAsync();

        if (result.Count() > 0)
        {
            var retVal = _mapper.Map<List<Category>, List<CategoryDto>>(result);
            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NoContent();
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll()
    {
        

        var result = await _categoryService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {
            
            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

        }

        return NoContent();
    }

    [HttpGet("getByIdDto/{id}")]
    public async Task<CategoryDto> GetByIdDto(string id)
    {
        var result = await _categoryService.GetById(id);

        var retVal = _mapper.Map<Category, CategoryDto>(result);

        return retVal;
    }
    [HttpGet("getById/{id}")]
    public Task<Category> GetById(string id)
    {
        var result = _categoryService.GetById(id);

        return result;
    }

    [HttpPost]
    public async Task<Category> AddCategory([FromBody] Category category)
    {
        await _categoryService.Create(category);
        return category;
    }

    [HttpPut]
    public async Task<ActionResult<Category>> UpdateCategory([FromBody] Category category)
    {

        await _categoryService.Update(category);
        return Ok(category);

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(string id)
    {

        await _categoryService.Delete(id);
        return Ok();
    }

}

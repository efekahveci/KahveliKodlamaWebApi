using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Core.Extensions;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
    public async Task<IActionResult> GetAllDataCategory()
    {
        var result = await _categoryService.GetAllQueryInc(x => x.Headings).ToListAsync();

        if (result.Count > 0)
        {


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

        }

        return NotFound();


    }

    [HttpGet("getAllDto")]
    public async Task<IActionResult> GetAllDtoCategory()
    {

        var result = await _categoryService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {
            var retVal = _mapper.Map<List<Category>, List<CategoryDto>>(result);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, retVal));

        }

        return NotFound();
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAllCategory()
    {


        var result = await _categoryService.GetAllQuery.ToListAsync();

        if (result.Count > 0)
        {

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, result));

        }

        return NotFound();
    }

    [HttpGet("getByIdDto/{id}")]
    public async Task<IActionResult> GetByIdDtoCategory(string id)
    {

        var result = await _categoryService.GetById(id);


        if (result != null)
        {
            var retVal = _mapper.Map<Category, CategoryDto>(result);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<CategoryDto> { retVal }));
        }

        return NotFound();

    }
    [HttpGet("getById/{id}")]
    public async Task<IActionResult> GetByIdCategory(string id)
    {
        var result = await _categoryService.GetByIdInc(id, x => x.Headings);


        if (result != null)
        {


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk, new List<Category> { result }));
        }

        return NotFound();
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddCategory([FromBody] CategoryDto category)
    {

        if (ModelState.IsValid)
        {

            var result = _mapper.Map<CategoryDto, Category>(category);

            await _categoryService.Create(result);


            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }


        return NotFound(new ResponseResult(Domain.Enum.ResponseCode.Not_Found, MessageHelper.validError));

    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateCategory([FromBody] CategoryDto category)
    {

        if (ModelState.IsValid)
        {

            await _categoryService.UpdateCategory(category);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }
        return NotFound();


    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(string id)
    {

        if (ModelState.IsValid)
        {

            await _categoryService.Delete(id);

            return Ok(new ResponseResult(Domain.Enum.ResponseCode.OK, MessageHelper.validOk));

        }
        return NotFound();
    }

}

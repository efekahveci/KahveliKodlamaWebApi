using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
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
        public async Task<List<Category>> GetAllData()
        {
            var result = await _categoryService.GetAll(x => x.Headings);

            return result;
        }

        [HttpGet("getAllDto")]
        public List<CategoryDto> GetAllDto()
        {
            var result = _categoryService.GetAll();

            var retVal = _mapper.Map<Task<List<Category>>, List<CategoryDto>>(result);

            return retVal;
        }

        [HttpGet("getAll")]
        public Task<List<Category>> GetAll()
        {
            var result = _categoryService.GetAll();

            return result;
        }

        [HttpGet("getByIdDto/{id}")]
        public async Task<CategoryDto> GetByIdDto(int id)
        {
            var result = await _categoryService.GetById(id);

            var retVal = _mapper.Map<Category, CategoryDto>(result);

            return retVal;
        }
        [HttpGet("getById/{id}")]
        public Task<Category> GetById(int id)
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
        public async Task<IActionResult> DeleteCategory(int id)
        {

            await _categoryService.Delete(id);
            return Ok();
        }

    }
}

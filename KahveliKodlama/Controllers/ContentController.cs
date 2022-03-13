using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;
        private readonly IMapper _mapper;

        public ContentController(IContentService contentService, IMapper mapper)
        {
            _contentService = contentService;
            _mapper = mapper;
        }

        [HttpGet("getAllDto")]
        public List<ContentDto> GetAllDto()
        {
            var result = _contentService.GetAllQuery.ToListAsync();

            var retVal = _mapper.Map<Task<List<Content>>, List<ContentDto>>(result);

            return retVal;
        }

        [HttpGet("getAll")]
        public Task<List<Content>> GetAll()
        {
            var result = _contentService.GetAllQuery.ToListAsync();

            return result;
        }

        [HttpGet("getByIdDto/{id}")]
        public async Task<ContentDto> GetByIdDto(string id)
        {
            var result = await _contentService.GetById(id);

            var retVal = _mapper.Map<Content, ContentDto>(result);

            return retVal;
        }

        [HttpGet("getById/{id}")]
        public Task<Content> GetById(string id)
        {
            var result = _contentService.GetById(id);

            return result;
        }

        [HttpPost]
        public async Task<Content> AddContent([FromBody] Content content)
        {
            await _contentService.Create(content);
            return content;
        }

        [HttpPut]
        public async Task<ActionResult<Content>> UpdateContent([FromBody] Content content)
        {

            await _contentService.Update(content);
            return Ok(content);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContent(string id)
        {

            await _contentService.Delete(id);
            return Ok();
        }
    }
}

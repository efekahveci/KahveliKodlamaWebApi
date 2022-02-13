using AutoMapper;
using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveliKodlama.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet("getAllDto")]
        public List<ContactDto> GetAllDto()
        {
            var result = _contactService.GetAll();


            var retVal = _mapper.Map<Task<List<Contact>>, List<ContactDto>>(result);

            return retVal;
        }
        [HttpGet("getAll")]
        public Task<List<Contact>> GetAll()
        {
            var result = _contactService.GetAll();

            return result;
        }

        [HttpGet("getByIdDto/{id}")]
        public async Task<ContactDto> GetByIdDto(int id)
        {
            var result = await _contactService.GetById(id);

            var retVal = _mapper.Map<Contact, ContactDto>(result);

            return retVal;
        }
        [HttpGet("getById/{id}")]
        public Task<Contact> GetById(int id)
        {
            var result = _contactService.GetById(id);

            return result;
        }

        [HttpPost("addPost")]
        public async Task<Contact> AddContact([FromBody] Contact contact)
        {
            await _contactService.Create(contact);
            return contact;
        }

        [HttpPut]
        public async Task<ActionResult<Contact>> UpdateContact([FromBody] Contact contact)
        {

            await _contactService.Update(contact);
            return Ok(contact);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {

            await _contactService.Delete(id);
            return Ok();
        }
    }
}

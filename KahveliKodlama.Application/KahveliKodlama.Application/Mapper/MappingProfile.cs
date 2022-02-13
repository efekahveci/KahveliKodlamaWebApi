using AutoMapper;
using KahveliKodlama.Domain.Entities;
using KahveliKodlama.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KahveliKodlama.Application.CQRS.Commands;

namespace KahveliKodlama.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Member, MemberDto>().ReverseMap();

            CreateMap<Heading, HeadingDto>().ReverseMap();
        
            CreateMap<Content, ContentDto>().ReverseMap();
        
            CreateMap<Contact, ContactDto>().ReverseMap();
          
            CreateMap<Category, CategoryDto>().ReverseMap();
    
            CreateMap<Member, UpdateMember>().ReverseMap();

            CreateMap<Member, RegisterDto>().ReverseMap();
            CreateMap<Member, RegisterDto>().ReverseMap();

       

        }
    }
}

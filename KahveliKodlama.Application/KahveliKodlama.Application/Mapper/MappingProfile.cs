using AutoMapper;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using System;

namespace KahveliKodlama.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Mail, MailDto>()
           .ReverseMap();

        CreateMap<Member, MemberDto>()
            .ReverseMap();

        CreateMap<Heading, HeadingDto>()
            .ReverseMap();
    
        CreateMap<Content, ContentDto>().ReverseMap();
    
        CreateMap<Contact, ContactDto>().ReverseMap();

        CreateMap<Category, CategoryDto>().ReverseMap();

        CreateMap<Member, RegisterDto>().ReverseMap();
        CreateMap<Member, RegisterDto>().ReverseMap();
        CreateMap<Exception, ExceptionDto>().ReverseMap();


    }
}

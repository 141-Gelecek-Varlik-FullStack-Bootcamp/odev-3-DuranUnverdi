using AutoMapper;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //User tablosundan UserDto tablosuna mapleme işlemini yapıyoruz
            CreateMap<User, UserDto>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.Name + " " + source.SurName))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));
        }
    }
}

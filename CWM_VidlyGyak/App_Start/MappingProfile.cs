using AutoMapper;
using CWM_VidlyGyak.DTOS;
using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CWM_VidlyGyak.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Custumer, CustumerDTO>();
            Mapper.CreateMap<CustumerDTO, Custumer>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MovieDTO, Movie>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<Genre, GenreDTO>();

        }
    }
}

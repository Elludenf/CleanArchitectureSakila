using Application.Films.Commands;
using Application.Films.Dto;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.MappingProfiles
{
    public class FilmMappingProfile: Profile
    {
        public FilmMappingProfile()
        {
            CreateMap<CreateFilmCommand, Film>();
            CreateMap<UpdateFilmCommand, Film>();
            CreateMap<Film, FilmDto>();
        }

    }
}

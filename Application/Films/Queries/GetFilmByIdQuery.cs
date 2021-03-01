using Application.Films.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.Queries
{
    public class GetFilmByIdQuery: IRequest<FilmDto>
    {
        public int film_id { get; set; }

    }
}

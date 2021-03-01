using Application.Films.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.Queries
{
    public class GetAllFilmsQuery: IRequest<List<FilmDto>>
    {
    }
}

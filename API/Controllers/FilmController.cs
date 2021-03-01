using Application.Films.Dto;
using Application.Films.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<FilmDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllFilmsQuery());
        }
    }
}

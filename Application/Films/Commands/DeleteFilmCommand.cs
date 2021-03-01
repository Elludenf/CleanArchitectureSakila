using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.Commands
{
    public class DeleteFilmCommand: IRequest<int>
    {
        public int film_id { get; set; }
    }
}

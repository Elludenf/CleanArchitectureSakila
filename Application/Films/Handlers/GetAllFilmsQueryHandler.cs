using Application.Films.Dto;
using Application.Films.Queries;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Films.Handlers
{
    public class GetAllFilmsQueryHandler : IRequestHandler<GetAllFilmsQuery, List<FilmDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllFilmsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<FilmDto>> Handle(GetAllFilmsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Films.GetAll();
            return _mapper.Map<List<FilmDto>>(result.ToList());
        }
    }
}

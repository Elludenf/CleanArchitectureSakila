using Application.Films.MappingProfiles;
using Application.Interfaces;
using AutoMapper;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Films.Handlers
{
    public class UpdateFilmCommandHandler : IRequestHandler<UpdateFilmCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateFilmCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateFilmCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Films.Update(_mapper.Map<Film>(request));
            return result;
        }
    }
}

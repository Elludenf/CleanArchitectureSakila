using Application.Films.Commands;
using Application.Interfaces;
using AutoMapper;
using Core.Entities;
using MediatR;

using System.Threading;
using System.Threading.Tasks;

namespace Application.Films.Handlers
{
    public class CreateFilmCommandHandler : IRequestHandler<CreateFilmCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateFilmCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateFilmCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Films.Add(_mapper.Map<Film>(request));
            return result;
        }
    }
}

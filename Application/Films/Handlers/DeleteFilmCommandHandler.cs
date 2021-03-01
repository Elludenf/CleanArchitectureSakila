using Application.Films.Commands;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Films.Handlers
{
    public class DeleteFilmCommandHandler: IRequestHandler<DeleteFilmCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFilmCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(DeleteFilmCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Films.Delete(request.film_id);
            return result;
        }
    }
}

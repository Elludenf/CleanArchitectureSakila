using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IFilmRepository filmRepository)
        {
            Films = filmRepository;
        }

        public IFilmRepository Films { get; }
    }

}

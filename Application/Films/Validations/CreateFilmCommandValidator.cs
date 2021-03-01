using Application.Films.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.Validations
{
    public class CreateFilmCommandValidator: AbstractValidator<CreateFilmCommand>
    {
        public CreateFilmCommandValidator()
        {
            RuleFor(t => t.title).NotEmpty();
            RuleFor(t => t.language_id).NotEmpty();
            RuleFor(t => t.rental_duration).NotEmpty();
            RuleFor(t => t.rental_rate).NotEmpty();
            RuleFor(t => t.replacement_cost).NotEmpty();

        }
    }
}

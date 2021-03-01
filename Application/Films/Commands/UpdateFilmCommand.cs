using Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Films.MappingProfiles
{
    public class UpdateFilmCommand: IRequest<int>
    {
		public int film_id { get; set; }
		public string title { get; set; }
		public string? description { get; set; }
		public string? release_year { get; set; }
		public Language language_id { get; set; }
		public Language? original_language_id { get; set; }
		public byte rental_duration { get; set; }
		public decimal rental_rate { get; set; }
		public short? length { get; set; }
		public decimal replacement_cost { get; set; }
		public string? rating { get; set; }
		public string? special_features { get; set; }
	}
}

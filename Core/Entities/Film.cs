using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
	public class Film
	{
		public int film_id;
		public string title;
		public string description;
		public string release_year;
		public Language language_id;
		public Language original_language_id;
		public byte rental_duration;
		public decimal rental_rate;
		public short length;
		public decimal replacement_cost;
		public string rating;
		public string special_features;
		public DateTime last_update;
	}
}

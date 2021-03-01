using Application.Interfaces;
using Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace Infrastructure.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly IConfiguration _configuration;

        public FilmRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Film entity)
        {
            entity.last_update = DateTime.Now;

            var sql = "INSERT INTO film (title, description, release_year, language_id, original_language_id, rental_durantion, rental_rate, length, replacement_cost, rating, special_features, last_update) VALUES (@title, @description, @release_year, @language_id, @original_language_id, @rental_durantion, @rental_rate, @length, @replacement_cost, @rating, @special_features, @last_update) ";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }

            //throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Film> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Film>> GetAll()
        {

            var sql = "SELECT * FROM film";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.QueryAsync<Film>(sql);
                return affectedRows;
            }

            throw new NotImplementedException();
        }

        public Task<int> Update(Film entity)
        {
            throw new NotImplementedException();
        }
    }
}

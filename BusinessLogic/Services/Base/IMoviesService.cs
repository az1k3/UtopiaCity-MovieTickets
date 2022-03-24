using Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Base
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task<Movie> GetMovieByIdAsync(int id);
        Task AddAsync(Movie movie);
        Task<Movie> UpdateAsync(int id, Movie newMovie);
        Task DeleteAsync(int id);
    }
}

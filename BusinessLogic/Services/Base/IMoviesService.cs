using Data.Domain;
using Data.Models.Movies;
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
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data); 
        Task UpdateMovieAsync(NewMovieVM data); 
       
    }
}

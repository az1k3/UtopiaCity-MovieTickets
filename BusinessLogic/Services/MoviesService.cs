using BusinessLogic.Services.Base;
using Data.Domain;
using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            var result = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return result;
        }
        public async Task<Movie> GetByIdAsync(int id)
        {
            var result = await _context.Movies.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }

        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> UpdateAsync(int id, Movie newMovie)
        {
            _context.Update(newMovie);
            await _context.SaveChangesAsync();
            return newMovie;
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Movies.FirstOrDefaultAsync(n => n.Id == id);
            _context.Movies.Remove(result);
            await _context.SaveChangesAsync();
        }

        
    }
}

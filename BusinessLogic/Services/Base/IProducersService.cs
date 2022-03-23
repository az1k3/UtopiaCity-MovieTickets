using Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Base
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Producer> GetByIdAsync(int id);
        Task AddAsync(Producer producer);
        Task<Producer> UpdateAsync(int id, Producer newProducer);
        Task DeleteAsync(int id);
    }
}

using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public interface IEntityRepo<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(uint id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(uint id, TEntity entity);
        Task DeleteAsync(uint id);
        Task<TEntity> GetByAttrAsync(string value);
    }
}

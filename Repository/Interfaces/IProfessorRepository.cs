using ProjetoEscola.Libary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Repository.Interfaces
{
    public interface IProfessorRepository
    {
        Task<IEnumerable<Professor>> GetAllAsync();
        Task<Professor> GetByIdAsync(int id);
        Task AddAsync(Professor professor);
        Task UpdateAsync(Professor professor);
        Task DeleteAsync(int id);
    }
}

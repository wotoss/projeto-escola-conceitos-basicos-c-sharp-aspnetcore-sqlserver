using ProjetoEscola.Libary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Services.Interfaces
{
    public interface IProfessorService
    {
        Task<IEnumerable<Professor>> ListarProfessoresAsync();
        Task<Professor> ObterProfessorPorIdAsync(int id);
        Task AdicionarProfessorAsync(Professor professor);
        Task AtualizarProfessorAsync(Professor professor);
        Task RemoverProfessorAsync(int id);
    }
}

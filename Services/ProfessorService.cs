using ProjetoEscola.Libary.Domain;
using ProjetoEscola.Libary.Repository.Interfaces;
using ProjetoEscola.Libary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _repo;

        public ProfessorService(IProfessorRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Professor>> ListarProfessoresAsync()
        {
            // 🔴 Exemplo de regra de negócio: só retorna professores ativos (se tivesse campo Ativo)
            return await _repo.GetAllAsync();
        }

        public async Task<Professor> ObterProfessorPorIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task AdicionarProfessorAsync(Professor professor)
        {
            // 🔴 Aqui poderia ter validação de negócio, exemplo:
            // if (string.IsNullOrEmpty(professor.Nome)) throw new Exception("Nome é obrigatório");

            await _repo.AddAsync(professor);
        }

        public async Task AtualizarProfessorAsync(Professor professor)
        {
            await _repo.UpdateAsync(professor);
        }

        public async Task RemoverProfessorAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }
    }
}


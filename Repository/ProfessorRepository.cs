using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Libary.Domain;
using ProjetoEscola.Libary.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
            private readonly EscolaContext _context;

            public ProfessorRepository(EscolaContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<Professor>> GetAllAsync()
            {
                return await _context.Professores.ToListAsync();
            }

            public async Task<Professor> GetByIdAsync(int id)
            {
                return await _context.Professores.FindAsync(id);
            }

            public async Task AddAsync(Professor professor)
            {
                _context.Professores.Add(professor);
                await _context.SaveChangesAsync();
            }

            public async Task UpdateAsync(Professor professor)
            {
                _context.Professores.Update(professor);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteAsync(int id)
            {
                var professor = await GetByIdAsync(id);
                if (professor != null)
                {
                    _context.Professores.Remove(professor);
                    await _context.SaveChangesAsync();
                }
            }
        }
}

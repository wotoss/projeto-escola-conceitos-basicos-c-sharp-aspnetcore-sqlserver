using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Libary.Domain;
using ProjetoEscola.Libary.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfessorMappings());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Professor> Professores { get; set; } // 🔴 Representa a tabela Professores
    }
}

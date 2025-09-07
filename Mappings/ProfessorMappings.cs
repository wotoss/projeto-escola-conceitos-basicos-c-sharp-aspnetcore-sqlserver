using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Libary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Mappings
{
    public class ProfessorMappings : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professores"); // Nome da tabela

            builder.HasKey(p => p.Id); // PK

            builder.Property(p => p.Nome)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Disciplina)
                   .HasMaxLength(50)
                   .IsRequired();

            // Email - obrigatório
            builder.Property(p => p.Email)
                   .HasMaxLength(120)
                   .IsRequired(); // 🔴 agora é NOT NULL

            builder.Property(p => p.DataAdmissao)
                   .HasColumnType("date");
        }
    }
}

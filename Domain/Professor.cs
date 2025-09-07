using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Libary.Domain
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string Email { get; set; }   
        public DateTime DataAdmissao { get; set; }
    }
 }



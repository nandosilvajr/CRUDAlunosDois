using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Turma
    {
        public int TurmaId { get; set; }   
        public List<Aluno> Alunos { get; set; }
        public List<Professor> Professores { get; set; }
    }
}

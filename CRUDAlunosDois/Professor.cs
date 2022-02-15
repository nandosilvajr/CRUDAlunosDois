using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Professor
    {

        public int ProfessorId { get; set; }   
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public string NomeCompleto {
        get
            {
                return $"{Nome} {Apelido}";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCCursos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; private set; }

        public Aluno(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }

        public bool PodeMatricular(Curso curso)
        {
            return Disciplinas.Count < 6 && !Disciplinas.Any(d => d.Curso == curso);
        }
    }
}

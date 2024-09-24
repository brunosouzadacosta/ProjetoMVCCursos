using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCCursos.Models
{
    public class Escola
    {
        public List<Curso> Cursos { get; private set; }

        public Escola()
        {
            Cursos = new List<Curso>();
        }

        public bool AdicionarCurso(Curso curso)
        {
            if (Cursos.Count < 5)
            {
                Cursos.Add(curso);
                return true;
            }
            return false;
        }

        public Curso PesquisarCurso(int id)
        {
            return Cursos.FirstOrDefault(c => c.Id == id);
        }

        public bool RemoverCurso(Curso curso)
        {
            if (curso.Disciplinas.Count == 0)
            {
                Cursos.Remove(curso);
                return true;
            }
            return false;
        }
        public Aluno PesquisarAluno(int idAluno)
        {
            foreach (var curso in Cursos)
            {
                foreach (var disciplina in curso.Disciplinas)
                {
                    var aluno = disciplina.Alunos.FirstOrDefault(a => a.Id == idAluno);
                    if (aluno != null)
                    {
                        return aluno;
                    }
                }
            }
            return null; // Retorna null se o aluno não for encontrado em nenhuma disciplina
        }
    }
}

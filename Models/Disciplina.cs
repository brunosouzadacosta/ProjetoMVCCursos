using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCCursos.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Aluno> Alunos { get; private set; }
        public Curso Curso { get; private set; }

        public Disciplina(int id, string descricao, Curso curso)
        {
            Id = id;
            Descricao = descricao;
            Curso = curso;
            Alunos = new List<Aluno>();
        }

        public bool MatricularAluno(Aluno aluno)
        {
            if (Alunos.Count < 15 && aluno.PodeMatricular(Curso))
            {
                Alunos.Add(aluno);
                aluno.Disciplinas.Add(this);
                return true;
            }
            return false;
        }

        public bool DesmatricularAluno(Aluno aluno)
        {
            if (Alunos.Contains(aluno))
            {
                Alunos.Remove(aluno);
                aluno.Disciplinas.Remove(this);
                return true;
            }
            return false;
        }
    }
}


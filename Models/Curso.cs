using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVCCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Disciplina> Disciplinas { get; private set; }

        public Curso(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Disciplinas = new List<Disciplina>();
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            if (Disciplinas.Count < 12)
            {
                Disciplinas.Add(disciplina);
                return true;
            }
            return false;
        }

        public Disciplina PesquisarDisciplina(int id)
        {
            return Disciplinas.FirstOrDefault(d => d.Id == id);
        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {
            if (disciplina.Alunos.Count == 0)
            {
                Disciplinas.Remove(disciplina);
                return true;
            }
            return false;
        }
    }
}

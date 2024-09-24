using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMVCCursos.Models;

namespace ProjetoMVCCursos.Controller
{
    public class EscolaController
    {
        private Escola escola;

        public EscolaController()
        {
            escola = new Escola();
        }

        public void AdicionarCurso()
        {
            Console.Write("Digite o ID do curso: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do curso: ");
            string descricao = Console.ReadLine();

            Curso curso = new Curso(id, descricao);
            if (escola.AdicionarCurso(curso))
            {
                Console.WriteLine("Curso adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar o curso. Limite atingido.");
            }
        }

        public void PesquisarCurso()
        {
            Console.Write("Digite o ID do curso: ");
            int id = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(id);
            if (curso != null)
            {
                Console.WriteLine($"Curso: {curso.Descricao}");
                foreach (var disciplina in curso.Disciplinas)
                {
                    Console.WriteLine($" - Disciplina: {disciplina.Descricao}");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }

        public void RemoverCurso()
        {
            Console.Write("Digite o ID do curso: ");
            int id = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(id);
            if (curso != null)
            {
                if (escola.RemoverCurso(curso))
                {
                    Console.WriteLine("Curso removido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não foi possível remover o curso. Existem disciplinas associadas.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }

        public void AdicionarDisciplinaAoCurso()
        {
            Console.Write("Digite o ID do curso: ");
            int idCurso = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(idCurso);
            if (curso != null)
            {
                Console.Write("Digite o ID da disciplina: ");
                int idDisciplina = int.Parse(Console.ReadLine());

                Console.Write("Digite a descrição da disciplina: ");
                string descricaoDisciplina = Console.ReadLine();

                Disciplina disciplina = new Disciplina(idDisciplina, descricaoDisciplina, curso);
                if (curso.AdicionarDisciplina(disciplina))
                {
                    Console.WriteLine("Disciplina adicionada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não foi possível adicionar a disciplina. Limite atingido.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }

        public void PesquisarDisciplina()
        {
            Console.Write("Digite o ID do curso: ");
            int idCurso = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(idCurso);
            if (curso != null)
            {
                Console.Write("Digite o ID da disciplina: ");
                int idDisciplina = int.Parse(Console.ReadLine());

                Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                if (disciplina != null)
                {
                    Console.WriteLine($"Disciplina: {disciplina.Descricao}");
                    Console.WriteLine("Alunos matriculados:");
                    foreach (var aluno in disciplina.Alunos)
                    {
                        Console.WriteLine($" - {aluno.Nome}");
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }


        public void RemoverDisciplinaDoCurso()
        {
            Console.Write("Digite o ID do curso: ");
            int idCurso = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(idCurso);
            if (curso != null)
            {
                Console.Write("Digite o ID da disciplina: ");
                int idDisciplina = int.Parse(Console.ReadLine());

                Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                if (disciplina != null)
                {
                    if (disciplina.Alunos.Count == 0)
                    {
                        if (curso.RemoverDisciplina(disciplina))
                        {
                            Console.WriteLine("Disciplina removida com sucesso.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não é possível remover a disciplina. Existem alunos matriculados.");
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }


        public void MatricularAlunoNaDisciplina()
        {
            Console.Write("Digite o ID do curso: ");
            int idCurso = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(idCurso);
            if (curso != null)
            {
                Console.Write("Digite o ID da disciplina: ");
                int idDisciplina = int.Parse(Console.ReadLine());

                Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                if (disciplina != null)
                {
                    Console.Write("Digite o ID do aluno: ");
                    int idAluno = int.Parse(Console.ReadLine());

                    Aluno aluno = escola.PesquisarAluno(idAluno);
                    if (aluno != null)
                    {
                        if (disciplina.MatricularAluno(aluno))
                        {
                            Console.WriteLine($"Aluno {aluno.Nome} matriculado com sucesso na disciplina {disciplina.Descricao}.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível matricular o aluno. Limite de alunos atingido ou aluno já está matriculado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }


        public void RemoverAlunoDaDisciplina()
        {
            Console.Write("Digite o ID do curso: ");
            int idCurso = int.Parse(Console.ReadLine());

            Curso curso = escola.PesquisarCurso(idCurso);
            if (curso != null)
            {
                Console.Write("Digite o ID da disciplina: ");
                int idDisciplina = int.Parse(Console.ReadLine());

                Disciplina disciplina = curso.PesquisarDisciplina(idDisciplina);
                if (disciplina != null)
                {
                    Console.Write("Digite o ID do aluno: ");
                    int idAluno = int.Parse(Console.ReadLine());

                    Aluno aluno = escola.PesquisarAluno(idAluno);
                    if (aluno != null)
                    {
                        if (disciplina.DesmatricularAluno(aluno))
                        {
                            Console.WriteLine($"Aluno {aluno.Nome} removido com sucesso da disciplina {disciplina.Descricao}.");
                        }
                        else
                        {
                            Console.WriteLine("O aluno não está matriculado nesta disciplina.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                }
                else
                {
                    Console.WriteLine("Disciplina não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }
        }

        public void PesquisarAluno()
        {
            Console.Write("Digite o ID do aluno: ");
            int idAluno = int.Parse(Console.ReadLine());

            Aluno aluno = escola.PesquisarAluno(idAluno);
            if (aluno != null)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine("Disciplinas matriculadas:");
                foreach (var disciplina in aluno.Disciplinas)
                {
                    Console.WriteLine($" - {disciplina.Descricao}");
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

    }
}

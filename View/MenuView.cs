using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMVCCursos.Controller;

namespace ProjetoMVCCursos.View
{
    // View/MenuView.cs
    public class MenuView
    {
        private EscolaController escolaController;

        public MenuView()
        {
            escolaController = new EscolaController();
        }

        public void ExibirMenu()
        {
            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar curso");
                Console.WriteLine("2. Pesquisar curso");
                Console.WriteLine("3. Remover curso");
                Console.WriteLine("4. Adicionar disciplina no curso");
                Console.WriteLine("5. Pesquisar disciplina");
                Console.WriteLine("6. Remover disciplina do curso");
                Console.WriteLine("7. Matricular aluno na disciplina");
                Console.WriteLine("8. Remover aluno da disciplina");
                Console.WriteLine("9. Pesquisar aluno");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        escolaController.AdicionarCurso();
                        break;
                    case 2:
                        escolaController.PesquisarCurso();
                        break;
                    case 3:
                        escolaController.RemoverCurso();
                        break;
                    case 4:
                        escolaController.AdicionarDisciplinaAoCurso();
                        break;
                    case 5:
                        escolaController.PesquisarDisciplina();
                        break;
                    case 6:
                        escolaController.RemoverDisciplinaDoCurso();
                        break;
                    case 7:
                        escolaController.MatricularAlunoNaDisciplina();
                        break;
                    case 8:
                        escolaController.RemoverAlunoDaDisciplina();
                        break;
                    case 9:
                        escolaController.PesquisarAluno();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

    }
}
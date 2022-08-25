using Aula2;

namespace AulaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina("BackEndII", 777, 20);
            string entrada;
            Aluno aluno;
            do
            {
                Console.Clear();
                Console.WriteLine("Entre com a Opção Desejada:");
                Console.WriteLine("1 Cadastrar Aluno");
                Console.WriteLine("2 Lancar Nota");
                Console.WriteLine("3 Consultar Nota");
                Console.WriteLine("4 Listar Nota");
                Console.WriteLine("5 Lançar falta");
                Console.WriteLine("sair (Para encerrar)");
                
                entrada = Console.ReadLine();
                
                switch (entrada)
                {
                    case "1": disciplina.CadastrarAlunoViaConsole();
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        break;
                    case "2":
                        Console.WriteLine("Entre com Nome ou Matricula do Aluno para lancar nota:");
                        try
                        {
                            aluno = disciplina.LocalizarAluno(Console.ReadLine());
                            Console.WriteLine($"Localizado : Aluno: {aluno.Nome} Matricula: {aluno.Matricula}");

                            Console.WriteLine("Entre com nota da np1");
                            double np1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Entre com nota da np2");
                            double np2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Entre com nota do trabalho");
                            double trapalho = Convert.ToDouble(Console.ReadLine());

                            disciplina.LancarNota(aluno, np1, np2, trapalho);
                            Console.WriteLine("Nota Final: " + disciplina.MapaDeNotas[aluno]);
                        }
                        catch
                        {
                            Console.WriteLine("Aluno nao encontrado");
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Entre com Nome ou Matricula do Aluno para Consulta nota:");
                            aluno = disciplina.LocalizarAluno(Console.ReadLine());
                            Console.WriteLine(
                                $" Aluno: {aluno.Nome} Matricula: {aluno.Matricula} Nota Final:  {disciplina.MapaDeNotas[aluno]}");

                        }
                        catch
                        {
                            Console.WriteLine("Aluno nao encontrado");
                        }
                        break;
                    case "4":
                        foreach (KeyValuePair<Aluno, double> alunoAtual in disciplina.MapaDeNotas)
                        {
                            Console.WriteLine($"Aluno: {alunoAtual.Key.Nome} Matricula: {alunoAtual.Key.Matricula} Nota Final: {alunoAtual.Value}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Entre com Nome ou Matricula do Aluno para lancar falta:");
                        try
                        {
                            aluno = disciplina.LocalizarAluno(Console.ReadLine());
                            Console.WriteLine($"Localizado : Aluno: {aluno.Nome} Matricula: {aluno.Matricula}");
                            Console.WriteLine("Entre com as faltas do aluno:");
                            int faltas = Convert.ToInt32(Console.ReadLine());
                            disciplina.LancarFalta(aluno, faltas);
                            Console.WriteLine("Total de faltas: " + disciplina.MapaDeFaltas[aluno]);
                        }
                        catch
                        {
                            Console.WriteLine("Aluno nao encontrado");
                        }
                        break;
                    case "sair":
                        Console.WriteLine("Saindo ...");
                        break;
                    default: Console.WriteLine("Opcao Invalida");
                        break;
                }
                Console.ReadKey();
            } while (entrada != "sair");
        }
    }
}
namespace Aula2
{
    public class Aluno
    {
        public static int _matriculaBase =1;
        public String Nome { get; set; }
        public int Matricula { get; set; }
        public string Curso { get; set; }
        public Disciplina BackEnd { get; set; }

        public void CadastrarAlunoViaConsole() {
            Console.WriteLine("Entre com Nome do Aluno:");
            this.Nome = Console.ReadLine();
            this.Matricula = _matriculaBase;
            _matriculaBase++;
        }
    }
}
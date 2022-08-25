namespace Aula2
{
    public class Disciplina
    {
        
        public string Nome { get ;set; } 
        public int Codigo { get; set; }
        public int CargaHoraria { get; set; }
        public List<Aluno> ListaAlunos { get; set; }
        public Dictionary<Aluno, double> MapaDeNotas { get; set; }
        public Dictionary<Aluno, int> MapaDeFaltas { get; set; }

        public Disciplina(String Nome, int Codigo , int CargaHoraria) {
            this.Nome = Nome;
            this.Codigo = Codigo;
            this.CargaHoraria = CargaHoraria;
            
            ListaAlunos = new List<Aluno>();
            MapaDeNotas = new Dictionary<Aluno, double>();
            MapaDeFaltas = new Dictionary<Aluno, int>();
            
        }
        public Aluno LocalizarAluno(String strBusca)
        {
            bool isCodigo = false;
            int codigo = -1;
            
            try {
                codigo = Convert.ToInt32(strBusca);
                isCodigo = true;
            }
            catch {
                isCodigo = false;
            }
            
            if (isCodigo == true) //se for Codigo
                return ListaAlunos.First(o => o.Matricula == codigo);
            
            return ListaAlunos.First(o => o.Nome.Equals(strBusca));
        }

        public void LancarFalta(Aluno aluno, int faltas)
        {
            MapaDeFaltas[aluno] += faltas;
        }
        
        public void LancarNota(Aluno aluno, double np1, double np2, double trabalho) 
        {
            double notaFinal = 0;
            notaFinal =(np1 * 0.3) + (np2 * 0.3) + (trabalho * 0.4);
            MapaDeNotas[aluno] = notaFinal;
        }
        
        public void CadastrarAlunoViaConsole()
        {
            Aluno novoAluno = new Aluno();
            novoAluno.CadastrarAlunoViaConsole();
            ListaAlunos.Add(novoAluno);
            MapaDeNotas.Add(novoAluno, 0);
            MapaDeFaltas.Add(novoAluno, 0);
        }
    }
}
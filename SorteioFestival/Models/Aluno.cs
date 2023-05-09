namespace SorteioFestival.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int TotalPagamentos { get; set; }
        public List<int> NumeroSorteio { get; set; }
        public Aluno() { }
        public Aluno(int id, string nome, int totalPagamentos)
        {
            Id = id;
            Nome = nome;
            TotalPagamentos = totalPagamentos;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SorteioFestival.Models;

namespace SorteioFestival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class AlunoController : ControllerBase
    {
        List<Aluno> alunos = new();
        int minMesesPagos = 3;

        [HttpGet]
        public List<Aluno> GetAlunos()
        {
            return alunos;
        }

        [HttpGet("/random")]
        public Aluno GetRandomAluno()
        {
            Random rand = new();
            int maxNum = alunos.Last().NumeroSorteio.Last();
            int numero = rand.Next(maxNum);

            return alunos.Single(al => al.NumeroSorteio.Contains(numero));
        }

        public AlunoController()
        {
            alunos.Add(new Aluno(1, "Aghata Rocha", 0));
            alunos.Add(new Aluno(2, "Agatha Ruiz", 1));
            alunos.Add(new Aluno(3, "Ana Clara", 0));
            alunos.Add(new Aluno(4, "André", 1));
            alunos.Add(new Aluno(5, "Ariane", 0));
            alunos.Add(new Aluno(6, "Breno", 0));
            alunos.Add(new Aluno(7, "Bruno", 0));
            alunos.Add(new Aluno(8, "Camila", 0));
            alunos.Add(new Aluno(9, "Carlos", 0));
            alunos.Add(new Aluno(10, "Fernando", 2));
            alunos.Add(new Aluno(11, "Fillipe", 3));
            alunos.Add(new Aluno(12, "Gabriel Ribeiro", 1));
            alunos.Add(new Aluno(13, "Gabriel Nazario", 0));
            alunos.Add(new Aluno(14, "Gabrielle", 0));
            alunos.Add(new Aluno(15, "Gustavo", 0));
            alunos.Add(new Aluno(16, "Higor", 1));
            alunos.Add(new Aluno(17, "Inácio", 0));
            alunos.Add(new Aluno(18, "João Ambrosio", 0));
            alunos.Add(new Aluno(19, "João Pedro", 0));
            alunos.Add(new Aluno(20, "Juliane", 0));
            alunos.Add(new Aluno(21, "Letícia / Japa", 0));
            alunos.Add(new Aluno(22, "Lucas Nadalin", 0));
            alunos.Add(new Aluno(23, "Lucas Bassora", 0));
            alunos.Add(new Aluno(24, "Matheus / Mathias", 3));
            alunos.Add(new Aluno(25, "Melissa C.", 0));
            alunos.Add(new Aluno(26, "Melissa V.", 1));
            alunos.Add(new Aluno(27, "Miguel", 0));
            alunos.Add(new Aluno(28, "Murilo", 0));
            alunos.Add(new Aluno(29, "Nicolas", 0));
            alunos.Add(new Aluno(30, "Octávio", 0));
            alunos.Add(new Aluno(31, "Pedro", 0));
            alunos.Add(new Aluno(32, "Pietra", 1));
            alunos.Add(new Aluno(33, "Rebecca", 0));
            alunos.Add(new Aluno(34, "Sabrina", 0));
            alunos.Add(new Aluno(35, "Samuel", 0));
            alunos.Add(new Aluno(36, "Thiago", 0));

            int numero = 1;
            foreach(Aluno aluno in alunos)
            {
                List<int> sorteios = new();
                for(int i = minMesesPagos; i >= aluno.TotalPagamentos; i--)
                {
                    sorteios.Add(numero);
                    numero++;
                }
                alunos.Where(alu => alu.Id == aluno.Id).ToList().ForEach(alu => alu.NumeroSorteio = sorteios);
            }
        }
    }
}

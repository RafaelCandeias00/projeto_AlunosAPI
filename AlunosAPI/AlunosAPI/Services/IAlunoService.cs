using AlunosAPI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunosAPI.Services
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetAluno(int id);
        Task<IEnumerable<Aluno>> GetAlunoByNome(string nome);
        Task CreateAluno (Aluno aluno);
        Task UpdateAluno (Aluno aluno);
        Task DeleteAluno (Aluno aluno);
    }
}

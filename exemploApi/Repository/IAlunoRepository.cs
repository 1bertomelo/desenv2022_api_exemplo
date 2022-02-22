using exemploApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
	public interface IAlunoRepository
	{
		Task<IEnumerable<Aluno>> ObterTodos();
		Task<Aluno> ObterPorId(int id);
		Task Adicionar(Aluno reserva);
		Task Atualizar(Aluno reserva);
		void Deletar(int id);
	}
}

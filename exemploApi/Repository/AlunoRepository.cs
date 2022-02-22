using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
	public class AlunoRepository : IAlunoRepository
	{
		private AppDbContext _context = null;

		public AlunoRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(Aluno aluno)
		{
			await _context.Alunos.AddAsync(aluno);
			await _context.SaveChangesAsync();
			
		}

		public async Task Atualizar(Aluno aluno)
		{
			 _context.Alunos.Update(aluno);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.Alunos.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<Aluno> ObterPorId(int id)
		{
			return await _context.Alunos.FindAsync(id);
		}

		public async Task<IEnumerable<Aluno>> ObterTodos()
		{
			return await _context.Alunos.AsNoTracking().ToListAsync();
		}
	}
}

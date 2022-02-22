using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exemploApi.Context.Mappings
{
	public class AlunoMapping : IEntityTypeConfiguration<Aluno>
	{
		public void Configure(EntityTypeBuilder<Aluno> builder)
		{
			builder.HasKey(c => c.AlunoId);

			builder.Property(c => c.Nome)
				.HasMaxLength(256)
				.IsRequired()
				.IsUnicode(false);


			builder.ToTable(name: "Aluno", schema: "dbo");
		}
	}
}

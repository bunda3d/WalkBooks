using Api.Data;
using Api.GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace Api.Services
{
	public class GenreService
	{
		private readonly WalkBooksDbContext _db;

		public GenreService(WalkBooksDbContext db)
		{
			_db = db;
		}

		public Task<List<GenreType>> GetGenresAsync(GenreMedium medium, CancellationToken ct)
		{
			return _db.Genres
				.Where(g => g.Medium == medium)
				.OrderBy(g => g.Name)
				.ToListAsync(ct);
		}
	}
}
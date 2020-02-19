using EFRepositories.Core.Domain;
using EFRepositories.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace EFRepositories.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context)
            : base(context) { }

        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }

        public PlutoContext PlutoContext
            => context as PlutoContext;
    }
}

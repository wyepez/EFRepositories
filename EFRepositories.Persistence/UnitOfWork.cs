using EFRepositories.Core;
using EFRepositories.Core.Repositories;
using EFRepositories.Persistence.Repositories;

namespace EFRepositories.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext context;

        public UnitOfWork(PlutoContext context)
        {
            this.context = context;
            Courses = new CourseRepository(context);
            Authors = new AuthorRepository(context);
        }

        public ICourseRepository Courses { get; }
        public IAuthorRepository Authors { get; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

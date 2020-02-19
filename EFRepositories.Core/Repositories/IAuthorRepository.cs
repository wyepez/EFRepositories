using EFRepositories.Core.Domain;

namespace EFRepositories.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}

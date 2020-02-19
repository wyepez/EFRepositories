using EFRepositories.Core.Domain;
using EFRepositories.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFRepositories.Persistence.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PlutoContext context)
            : base(context) { }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(c => c.Price).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return PlutoContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public PlutoContext PlutoContext
            => context as PlutoContext;
    }
}

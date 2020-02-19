using System.Collections.Generic;

namespace EFRepositories.Core.Domain
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public decimal Price { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual Cover Cover { get; set; }
        public bool IsBeginnerCourse => Level == 1;
    }
}

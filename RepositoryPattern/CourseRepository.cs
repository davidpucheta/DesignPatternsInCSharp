using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(PlutoContext context) : base(context)
        {
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            throw new NotImplementedException();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}

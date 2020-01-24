using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    public interface IUnitOfWork
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get;  }

        int Complete();
    }
}

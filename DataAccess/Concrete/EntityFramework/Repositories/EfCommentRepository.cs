using DataAccess.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCommentRepository : EfGenericRepository<Comment>, ICommentDal
    {
    }
}

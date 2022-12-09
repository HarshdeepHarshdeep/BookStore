using System;
using System.Collections.Generic;
using System.Text;

namespace HarshdeepsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverTypeRepository>
    {
        void Update(CoverTypeRepository CoverType);
    }
}

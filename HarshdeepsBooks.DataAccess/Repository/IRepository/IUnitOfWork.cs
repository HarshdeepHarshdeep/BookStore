using System;
using HarshdeepsBooks.DataAcces.Repository;
using HarshdeepsBookstore.DataAccess.Data;
using System.Collections.Generic;
using System.Text;

namespace HarshdeepsBooks.DataAcces.Repository.IRepository
{

    public interface IUnitOfWork : IDisposable
    
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }   
       

        void save();
    }
}

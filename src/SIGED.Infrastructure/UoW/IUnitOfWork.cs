using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}

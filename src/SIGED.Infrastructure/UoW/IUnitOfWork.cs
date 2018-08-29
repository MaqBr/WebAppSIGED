using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}

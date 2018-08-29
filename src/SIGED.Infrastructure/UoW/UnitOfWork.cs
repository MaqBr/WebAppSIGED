using SIGED.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.Infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SIGEDContext _context;
        private bool _disposed;

        public UnitOfWork(SIGEDContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

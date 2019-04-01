using System;
using System.Data;

namespace Cleaner.DataAccess.Infrastructure
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection { get; }
    }
}

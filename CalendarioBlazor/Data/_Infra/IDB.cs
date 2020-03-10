using System;
using System.Data.Common;

namespace CalendarioBlazor.Data._Infra
{
    public interface IDB : IDisposable
    {
        DbConnection GetConnection();
    }
}

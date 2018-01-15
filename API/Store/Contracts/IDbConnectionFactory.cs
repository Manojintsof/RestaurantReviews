using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CMMI.Store.Contracts
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}

using CMMI.Store.Contracts;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CMMI.Store.Base
{
    public class DataStore : IDataStore
    {
        private readonly IDbConnectionFactory connectionFactory;

        public int UserId { get; private set; }

        public DataStore(IDbConnectionFactory connection)
        {
            this.connectionFactory = connection;
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string query, object parameters = null, int? timeout = null)
        {
            IEnumerable<T> objs1;
            using (IDbConnection connection = this.connectionFactory.CreateConnection())
            {
                IEnumerable<T> objs = await connection.QueryAsync<T>(query, parameters, (IDbTransaction)null, timeout, new CommandType?());
                IEnumerable<T> result = objs;
                objs = (IEnumerable<T>)null;
                objs1 = result;
            }
            return objs1;
        }

        public void SetUserContext(int userId)
        {
            this.UserId = this.UserId;
        }
    }
}

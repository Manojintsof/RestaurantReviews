using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMMI.Store.Contracts
{
    public interface IDataStore
    {
        void SetUserContext(int userId);

        Task<IEnumerable<T>> GetListAsync<T>(string query, object parameter = null, int? timeout = null);
    }
}


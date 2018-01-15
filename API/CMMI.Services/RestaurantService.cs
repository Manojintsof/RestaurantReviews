using CMMI.Contracts;
using CMMI.Logger;
using CMMI.Logging.Contract;
using CMMI.Models;
using CMMI.Store.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMMI.Services
{
    public class RestaurantService : Service, IRestaurantService
    {
        private ILogger logger;
        IDataStore store;

        public RestaurantService(IDataStore store): base(store)
        {
            this.store = store;
            this.logger = new LoggerFactory(LoggerType.DB).GetLogger();//ToDo: Read from config file
        }

        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            var query = this.GetQueryAsync().Result;
            var result = await this.Store.GetListAsync<Restaurant>(query, null);
            logger.LogInfo("Restaurant list fetched successfully ");
            return result;
        }
    }
}

using CMMI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMMI.Contracts
{
    public interface IRestaurantService
    {
        Task<IEnumerable<Restaurant>> GetAllAsync();
    }
}

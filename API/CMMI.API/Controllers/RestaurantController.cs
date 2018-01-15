using CMMI.Contracts;
using CMMI.Logging.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMMI.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Restaurant")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;
        private readonly ILogger logger;
        
        public RestaurantController(IRestaurantService _restauranService, ILogger _logger)
        {
            this.restaurantService = _restauranService;
            this.logger = _logger;
        }
        

        [Route("GetRestaurants")]
        [HttpGet]
        public async Task<IActionResult>GetAll()
        {
            var restaurants = await this.restaurantService.GetAllAsync();
            return this.Ok(restaurants);
        }

        [HttpPost]
        public IEnumerable<string> Post(  )
        {
            return new string[] { "value1", "value2" };
        }
    }
}

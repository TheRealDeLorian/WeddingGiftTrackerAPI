
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Data.DataStores;

namespace WeddingGiftTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        private readonly ILogger<GiftGuestController> _logger;
        private readonly IDataStore dataStore;

        public GiftController(ILogger<GiftGuestController> logger, IDataStore dataStore)
        {
            _logger = logger;
        }

      

            [HttpGet]
        public async Task<string> Get()
        {
            return await Task.Run(() =>
            {
                return $"TODO: return all items";
            }); 
        }

        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return await Task.Run(() =>
            {
                return $"TODO: return the item with id  #{id}";
            } );
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await Task.Run(() =>
            {
                return $"TODO: delete the item with id #{id}";
            });
        }
    }
}

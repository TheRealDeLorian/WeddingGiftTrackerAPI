
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Data.DataStores;

namespace WeddingGiftTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GiftGuestController : ControllerBase
    {
        private readonly ILogger<GiftGuestController> _logger;
        private readonly IDataStore dataStore;

        public GiftGuestController(ILogger<GiftGuestController> logger, IDataStore dataStore)
        {
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Data.DataStores;

namespace WeddingGiftTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestController : ControllerBase
    {
        private readonly ILogger<GiftGuestController> _logger;
        private readonly IDataStore dataStore;

        public GuestController(ILogger<GiftGuestController> logger, IDataStore dataStore)
        {
        }
    }
}

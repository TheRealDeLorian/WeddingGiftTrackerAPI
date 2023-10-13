
using Microsoft.AspNetCore.Mvc;

namespace WeddingGiftTrackerAPI.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class GuestController : ControllerBase
    {
        private readonly ILogger<GuestController> _logger;
        private readonly IWeddingGiftTrackerService<Guest> dataStore;

        public GuestController(ILogger<GuestController> logger, IWeddingGiftTrackerService<Guest> dataStore)
        {
        }
    }
}

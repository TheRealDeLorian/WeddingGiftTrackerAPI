
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Services;

namespace WeddingGiftTrackerAPI.Controllers
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

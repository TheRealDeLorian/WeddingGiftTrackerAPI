
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Data;

namespace WeddingGiftTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeddingGiftController : ControllerBase
    {
        private readonly ILogger<WeddingGiftController>
        private readonly IDataStore dataStore;

        public WeddingGiftController(ILogger<WeddingGiftController> logger, IDataStore dataStore)
        {
        }
    }
}

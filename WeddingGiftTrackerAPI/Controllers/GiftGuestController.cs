
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Data.DataStores;
using WeddingGiftTrackerAPI.Data.Models;

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
            _logger = logger;
        }

        [HttpGet(Name = "GetGifts")]
        public IEnumerable<GiftGuest> Get()
        {
            return new[] {
                new GiftGuest() {
                    Id = 1,
                    GiftId = 1,
                    GuestId = 1,
                },
                new GiftGuest() {
                    Id = 2,
                    GiftId = 2,
                    GuestId = 1
                },
                new BoardGame() {
                    Id = 3,

                    Name = "Terraforming Mars",
                    Year = 2016
                }
            };
        }
}

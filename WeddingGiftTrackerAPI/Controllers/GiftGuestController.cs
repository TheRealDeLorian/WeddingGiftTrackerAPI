
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerAPI.Services;

namespace WeddingGiftTrackerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GiftGuestController : ControllerBase
    {
        private readonly ILogger<GiftGuestController> _logger;
        private readonly IWeddingGiftTrackerService<GiftGuest> _giftGuestService;

        public GiftGuestController(ILogger<GiftGuestController> logger, IWeddingGiftTrackerService<GiftGuest> giftGuestService)
        {
            _logger = logger;
            _giftGuestService = giftGuestService;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<GiftGuest>> Get()
        {
            var gifts = await _giftGuestService.GetAll();
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
                new GiftGuest() {
                    Id = 3,
                    GiftId = 3,
                    GuestId = 2
                }
            };
        }
    }
}

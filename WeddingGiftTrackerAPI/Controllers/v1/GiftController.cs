using WeddingGiftTrackerClassLibrary.Services;
using Microsoft.AspNetCore.Mvc;
using WeddingGiftTrackerClassLibrary.Data;



namespace WeddingGiftTrackerAPI.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class GiftController : ControllerBase
    {
        private readonly ILogger<GiftGuestController> _logger;
        private readonly IWeddingGiftTrackerService<Gift> _giftService;

        public GiftController(ILogger<GiftGuestController> logger, IWeddingGiftTrackerService<Gift> giftService)
        {
            _logger = logger;
            _giftService = giftService;
        }

        [HttpGet]
        public async Task<IEnumerable<GiftDTO>> Get()
        {
            var gifts = await _giftService.GetAll();
            return gifts.Select(MakeGiftDTO);
        }

        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            return await Task.Run(() =>
            {
                return $"TODO: return the item with id  #{id}";
            });
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await Task.Run(() =>
            {
                return $"TODO: delete the item with id #{id}";
            });
        }

        private GiftDTO MakeGiftDTO(Gift g)
        {
            return new GiftDTO
            {
                GiftName = g.GiftName,
                Description = g.Description,
                GiftType = g.GiftType.ToString(),
                //TODO: Make gifttype controller to be able to get this

            };
        }
    }
}

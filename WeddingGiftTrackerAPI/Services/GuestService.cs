using WeddingGiftTrackerAPI.Data;

namespace WeddingGiftTrackerAPI.Services;

public class GuestService : IWeddingGiftTrackerService<Guest>
{
    private readonly WeddingGiftDbContext context;
    private readonly ILogger<GiftService> logger;

    public GuestService(WeddingGiftDbContext context, ILogger<GiftService> logger)
    {
        this.context = context;
        this.logger = logger;
    }

    public Task<Guest> Add(Guest obj)
    {
        throw new NotImplementedException();
    }

    public Task<Guest> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Guest> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Guest>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Guest> Update(Guest obj)
    {
        throw new NotImplementedException();
    }
}

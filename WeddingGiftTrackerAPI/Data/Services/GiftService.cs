using WeddingGiftTrackerAPI.Data;
using WeddingGiftTrackerAPI.Data.DataStores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using WeddingGiftTrackerAPI.Data.DTOs;

namespace WeddingGiftTrackerAPI.Data.Models;

public class GiftService : IWeddingGiftTrackerService<Gift>
{
    private readonly WeddingGiftDbContext context;
    private readonly ILogger<GiftService> logger;

    public GiftService(WeddingGiftDbContext context, ILogger<GiftService> logger)
    {
        this.context = context;
        this.logger = logger;
    }

    public Task<Gift> Add(Gift obj)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Gift>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Gift> Update(Gift obj)
    {
        throw new NotImplementedException();
    }
}
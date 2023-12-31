﻿using WeddingGiftTrackerClassLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;


namespace WeddingGiftTrackerClassLibrary.Services;

public class GiftService : IWeddingGiftTrackerService<Gift>
{
    private readonly WeddingGiftDbContext _context;
    private readonly ILogger<GiftService> _logger;

    public GiftService(WeddingGiftDbContext context, ILogger<GiftService> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<IEnumerable<Gift>> GetAll()
    {
        return await _context.Gifts
                .Include(g => g.GiftGuests)
                .ToListAsync();
    }
    public async Task<Gift> Get(int id)
    {
        _logger.LogInformation("Getting gift {id}", id);
        return await _context.Gifts
            .Include(g => g.GiftGuests)
            .FirstOrDefaultAsync(g => g.Id == id);
    }

    public Task<Gift> Add(Gift obj)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> Delete(int id)
    {
        throw new NotImplementedException();
    }



    public Task<Gift> Update(Gift obj)
    {
        throw new NotImplementedException();
    }
}
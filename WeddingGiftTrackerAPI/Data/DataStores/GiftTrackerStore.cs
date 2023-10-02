using WeddingGiftTrackerAPI.Data;
using WeddingGiftTrackerAPI.Data.DataStores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using WeddingGiftTrackerAPI.Data.Models;

namespace Dadabase.Data;

public class GiftTrackerStore : IDataStore
{
    private readonly WeddingGiftDbContext context;
    private readonly ILogger<GiftTrackerStore> logger;

    public GiftTrackerStore(WeddingGiftDbContext context, ILogger<GiftTrackerStore> logger)
    {
        this.context = context;
        this.logger = logger;
    }



    public Task<IEnumerable<Gift>> GetAllGifts()
    {
        throw new NotImplementedException();
    }

    public Task<Gift> GetGift(int id, bool showDetails = false)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> AddGift(Gift gift)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> UpdateGift(Gift gift)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGift(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Gift>> GetAllGuests()
    {
        throw new NotImplementedException();
    }

    public Task<Gift> GetGuest(int id, bool showDetails = false)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> AddGuest(Gift gift)
    {
        throw new NotImplementedException();
    }

    public Task<Gift> UpdateGuest(Gift gift)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGuest(int id)
    {
        throw new NotImplementedException();
    }

    // Audience CRUD

    //public async Task<Audience> AddAudience(Audience audience)
    //{
    //    logger.LogInformation($"{nameof(AddAudience)}");

    //    context.Audiences.Add(audience);
    //    if(context.Audiences.Count() == 0 )
    //    {
    //        audience.Id = 1;
    //    }
    //    else
    //    {
    //        audience.Id = context.Audiences.Max(a => a.Id) + 1;
    //    }
    //    await context.SaveChangesAsync();
    //    return audience;
    //}

    //public async Task<IEnumerable<Audience>> GetAllAudiences()
    //{
    //    logger.LogInformation($"{nameof(GetAllAudiences)}");
    //    return await context.Audiences.ToListAsync();

    //}

    ////select * from audience a
    ////where a.id = id
    //public async Task<Audience> GetAudience(int id, bool showDetails = false)
    //{
    //    logger.LogInformation($"{nameof(GetAudience)} @ {id}");
    //    return await context.Audiences.FirstOrDefaultAsync(r => r.Id == id);
    //}

    //public async Task<Audience> UpdateAudience(Audience audience, int id)
    //{
    //    logger.LogInformation($"{nameof(UpdateAudience)} @ {audience.Id}");

    //    //var oldAudience = await context.Audiences.FirstOrDefaultAsync(a =>  a.Id == audience.Id);
    //    audience.Id = id;
    //    if (await context.Audiences.FindAsync(audience.Id) is Audience found) //found is the one from the db, audience is the one from the http request
    //    {
    //        context.Entry(found).CurrentValues.SetValues(audience);
    //        await context.SaveChangesAsync();
    //        return audience;
    //    }
    //    else
    //    {
    //        logger.LogInformation($"No {nameof(Audience)} entry @ {audience.Id}");
    //        // What to return ? Check how async and tasks work again
    //        return audience;
    //    }
    //}

    //public async Task DeleteAudience(int id)
    //{
    //    var existingItem = await context.Audiences.FindAsync(id);
    //    if (existingItem is null)
    //    {
    //        throw new ArgumentException($"Audience with id {id} does not exist");
    //    }
    //    context.Audiences.Where(A => A.Id == id).ExecuteDelete();
    //    await context.SaveChangesAsync();
    //}


    //// Audience Category CRUD

    //public async Task<Audiencecategory> AddAudiencecategory(Audiencecategory Audiencecategory)
    //{
    //    context.Audiencecategories.Add(Audiencecategory);
    //    await context.SaveChangesAsync();
    //    return Audiencecategory;
    //}

    //public async Task<IEnumerable<Audiencecategory>> GetAllAudienceCategories()
    //{
    //    return await context.Audiencecategories.ToListAsync();
    //}

    //public async Task<Audiencecategory> GetAudiencecategory(int id, bool showDetails = false)
    //{
    //    logger.LogInformation($"{nameof(GetAudiencecategory)} @ {id}");
    //    return await context.Audiencecategories.FirstOrDefaultAsync(r => r.Id == id);
    //}

    //public async Task<Audiencecategory> UpdateAudiencecategory(Audiencecategory Audiencecategory, int id)
    //{
    //    logger.LogInformation($"{nameof(UpdateAudiencecategory)} @ {Audiencecategory.Id}");

    //    Audiencecategory.Id = id;
    //    if (await context.Audiencecategories.FindAsync(Audiencecategory.Id) is Audiencecategory found) //found is the one from the db, audience is the one from the http request
    //    {
    //        context.Entry(found).CurrentValues.SetValues(Audiencecategory);
    //        await context.SaveChangesAsync();
    //        return Audiencecategory;
    //    }
    //    else
    //    {
    //        logger.LogInformation($"No {nameof(Audiencecategory)} entry @ {Audiencecategory.Id}");
    //        return Audiencecategory;
    //    }
    //}

    //public async Task DeleteAudiencecategory(int id)
    //{
    //    var existingItem = await context.Audiencecategories.FindAsync(id);
    //    if (existingItem is null)
    //    {
    //        throw new ArgumentException($"Audiencecategory with id {id} does not exist");
    //    }
    //    context.Audiencecategories.Remove(existingItem);
    //    await context.SaveChangesAsync();
    //}


    //// Delivered Joke CRUD

    //public async Task<Deliveredjoke> AddDeliveredjoke(Deliveredjoke deliveredjoke)
    //{
    //    context.Deliveredjokes.Add(deliveredjoke);
    //    await context.SaveChangesAsync();
    //    return deliveredjoke;
    //}

    //public async Task<IEnumerable<Deliveredjoke>> GetAllDeliveredjokes()
    //{
    //    return await context.Deliveredjokes.ToListAsync();

    //}

    //public async Task<Deliveredjoke> GetDeliveredjoke(int id, bool showDetails = false)
    //{
    //    logger.LogInformation($"{nameof(GetDeliveredjoke)} @ {id}");
    //    return await context.Deliveredjokes.FirstOrDefaultAsync(r => r.Id == id);
    //}

    //public async Task<Deliveredjoke> UpdateDeliveredjoke(Deliveredjoke deliveredjoke, int id)
    //{
    //    logger.LogInformation($"{nameof(UpdateDeliveredjoke)} @ {deliveredjoke.Id}");

    //    deliveredjoke.Id = id;
    //    if (await context.Deliveredjokes.FindAsync(deliveredjoke.Id) is Deliveredjoke found) //found is the one from the db, audience is the one from the http request
    //    {
    //        context.Entry(found).CurrentValues.SetValues(deliveredjoke);
    //        await context.SaveChangesAsync();
    //        return deliveredjoke;
    //    }
    //    else
    //    {
    //        logger.LogInformation($"No {nameof(Deliveredjoke)} entry @ {deliveredjoke.Id}");
    //        return deliveredjoke;
    //    }
    //}

    //public async Task DeleteDeliveredjoke(int id)
    //{
    //    var existingItem = await context.Deliveredjokes.FindAsync(id);
    //    if (existingItem is null)
    //    {
    //        throw new ArgumentException($"Deliveredjoke with id {id} does not exist");
    //    }
    //    context.Deliveredjokes.Remove(existingItem);
    //    await context.SaveChangesAsync();
    //}


    //// Joke CRUD 

    //public async Task<Joke> AddJoke(Joke joke)
    //{
    //    context.Jokes.Add(joke);
    //    await context.SaveChangesAsync();
    //    return joke;
    //}

    //public async Task<IEnumerable<Joke>> GetAllJokes()
    //{
    //    return await context.Jokes.ToListAsync();

    //}

    //public async Task<Joke> GetJoke(int id, bool showDetails = false)
    //{
    //    logger.LogInformation($"{nameof(GetJoke)} @ {id}");
    //    return await context.Jokes.FirstOrDefaultAsync(r => r.Id == id);
    //}

    //public async Task<Joke> UpdateJoke(Joke joke, int id)
    //{
    //    logger.LogInformation($"{nameof(UpdateJoke)} @ {joke.Id}");

    //    joke.Id = id;
    //    if (await context.Jokes.FindAsync(joke.Id) is Joke found) //found is the one from the db, audience is the one from the http request
    //    {
    //        context.Entry(found).CurrentValues.SetValues(joke);
    //        await context.SaveChangesAsync();
    //        return joke;
    //    }
    //    else
    //    {
    //        logger.LogInformation($"No {nameof(Joke)} entry @ {joke.Id}");
    //        return joke;
    //    }
    //}

    //public async Task DeleteJoke(int id)
    //{
    //    var existingItem = await context.Jokes.FindAsync(id);
    //    if (existingItem is null)
    //    {
    //        throw new ArgumentException($"Joke with id {id} does not exist");
    //    }
    //    context.Jokes.Remove(existingItem);
    //    await context.SaveChangesAsync();
    //}


    ////Joke Category CRUD

    //public async Task<Jokecategory> AddJokeCategory(Jokecategory Jokecategory)
    //{
    //    context.Jokecategories.Add(Jokecategory);
    //    await context.SaveChangesAsync();
    //    return Jokecategory;
    //}

    //public async Task<IEnumerable<Jokecategory>> GetAllJokeCategories()
    //{
    //    return await context.Jokecategories.ToListAsync();

    //}

    //public async Task<Jokecategory> GetJokeCategory(int id, bool showDetails = false)
    //{
    //    logger.LogInformation($"{nameof(GetJokeCategory)} @ {id}");
    //    return await context.Jokecategories.FirstOrDefaultAsync(r => r.Id == id);
    //}

    //public async Task<Jokecategory> UpdateJokeCategory(Jokecategory Jokecategory, int id)
    //{
    //    logger.LogInformation($"{nameof(UpdateJokeCategory)} @ {Jokecategory.Id}");

    //    Jokecategory.Id = id;
    //    if (await context.Jokecategories.FindAsync(Jokecategory.Id) is Jokecategory found) //found is the one from the db, audience is the one from the http request
    //    {
    //        context.Entry(found).CurrentValues.SetValues(Jokecategory);
    //        await context.SaveChangesAsync();
    //        return Jokecategory;
    //    }
    //    else
    //    {
    //        logger.LogInformation($"No {nameof(Jokecategory)} entry @ {Jokecategory.Id}");
    //        return Jokecategory;
    //    }
    //}

    //public async Task DeleteJokeCategory(int id)
    //{
    //    var existingItem = await context.Jokecategories.FindAsync(id);
    //    if (existingItem is null)
    //    {
    //        throw new ArgumentException($"Jokecategory with id {id} does not exist");
    //    }
    //    context.Jokecategories.Remove(existingItem);
    //    await context.SaveChangesAsync();
    //} 


    //// Addiional API services
    //public async Task<IEnumerable<Joke>> GetJokesByTag(int tagid)
    //{
    //    return
    //        await (from J in context.Jokes
    //                join CJ in context.Categorizedjokes
    //                    on J.Id equals CJ.Jokeid
    //                join JC in context.Jokecategories
    //                    on CJ.Jokecategoryid equals JC.Id
    //                where JC.Id == tagid
    //                select J).ToListAsync();
    //}

    //public async Task<IEnumerable<Joke>> GetJokesByAudience(int audienceid)
    //{
    //    return
    //        await (from J in context.Jokes
    //               join DJ in context.Deliveredjokes
    //                   on J.Id equals DJ.Jokeid
    //               join A in context.Audiences
    //                   on DJ.Audienceid equals A.Id
    //               where A.Id == audienceid
    //               select J
    //                    ).ToListAsync();
    //}

    //public async Task<IEnumerable<Joke>> GetJokesRankedByScore()
    //{
    //    return
    //        await (from J in context.Jokes
    //               join DJ in context.Deliveredjokes
    //                   on J.Id equals DJ.Jokeid
    //               join JR in context.Jokereactioncategories
    //                   on DJ.Jokereactionid equals JR.Id
    //               orderby JR.Score descending
    //               select J).ToListAsync();
    //}

    //public async Task<IEnumerable<Joke>> GetJokesRankedByScoreTag(int tagid)
    //{
    //    return
    //        await (from J in context.Jokes
    //               join DJ in context.Deliveredjokes
    //                    on J.Id equals DJ.Jokeid
    //               join JR in context.Jokereactioncategories
    //                    on DJ.Jokereactionid equals JR.Id
    //               join CJ in context.Categorizedjokes
    //                    on J.Id equals CJ.Jokeid
    //               join JC in context.Jokecategories
    //                    on CJ.Jokecategoryid equals JC.Id
    //               where JC.Id == tagid
    //               orderby JR.Score descending
    //               select J).ToListAsync();
    //}

    //public async Task<IEnumerable<Joke>> GetJokesRankedByScoreAudience(int audienceid)
    //{
    //    return
    //        await (from J in context.Jokes
    //               join DJ in context.Deliveredjokes
    //                    on J.Id equals DJ.Jokeid
    //               join JR in context.Jokereactioncategories
    //                    on DJ.Jokereactionid equals JR.Id
    //               join A in context.Audiences
    //                    on DJ.Audienceid equals A.Id
    //               where A.Id == audienceid
    //               orderby JR.Score descending
    //               select J).ToListAsync();
    //}

    //public async Task<IEnumerable<Deliveredjoke>> GetJokeByTelling(int id)
    //{
    //    return
    //        await (from DJ in context.Deliveredjokes
    //               join J in context.Jokes
    //                    on DJ.Jokeid equals J.Id
    //               where DJ.Jokeid == id
    //               select DJ).ToListAsync();
    //}


}
using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerAPI.Data.DataStores
{
    public interface IDataStore
    {
        Task<IEnumerable<Gift>> GetAllGifts();
        Task<Gift> GetGift(int id, bool showDetails = false);
        Task<Gift> AddGift(Gift gift);
        Task<Gift> UpdateGift(Gift gift);
        Task DeleteGift(int id);


        Task<IEnumerable<Gift>> GetAllGuests();
        Task<Gift> GetGift(int id, bool showDetails = false);
        Task<Gift> AddGift(Gift gift);
        Task<Gift> UpdateGift(Gift gift);
        Task DeleteGift(int id);
    }
}

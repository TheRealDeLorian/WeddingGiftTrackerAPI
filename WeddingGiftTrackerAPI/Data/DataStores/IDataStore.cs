using WeddingGiftTrackerAPI.Data.Models;

namespace WeddingGiftTrackerAPI.Data.DataStores
{
    public interface IDataStore //dedicated interface or base class. can be provided by framework, developer, or third party
    {
        Task<IEnumerable<Gift>> GetAllGifts();
        Task<Gift> GetGift(int id, bool showDetails = false);
        Task<Gift> AddGift(Gift gift);
        Task<Gift> UpdateGift(Gift gift);
        Task DeleteGift(int id);


        Task<IEnumerable<Gift>> GetAllGuests();
        Task<Gift> GetGuest(int id, bool showDetails = false);
        Task<Gift> AddGuest(Gift gift);
        Task<Gift> UpdateGuest(Gift gift);
        Task DeleteGuest(int id);
    }
}

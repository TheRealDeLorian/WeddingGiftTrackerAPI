namespace WeddingGiftTrackerAPI.Data
{
    public interface IDataStore
    {
        Task<IEnumerable<Gift>> GetAllGifts();
        Task<Gift> GetGift(int id, bool showDetails = false);
        Task<Gift> AddGift(Gift gift);
        Task<Gift> UpdateGift(Gift gift);
        Task DeleteGift(int id);
    }
}

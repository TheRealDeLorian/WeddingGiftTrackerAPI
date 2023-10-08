namespace WeddingGiftTrackerAPI.Data.DataStores
{
    public interface IWeddingGiftTrackerService<T> //dedicated interface or base class. can be provided by framework, developer, or third party
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T obj);
        Task<T> Update(T obj);
        Task<T> Delete(int id);

       
    }
}

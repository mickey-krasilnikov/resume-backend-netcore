using ResumeApp.Poco;

namespace ResumeApp.BusinessLogic.Services
{
	public interface ICrudService<TItem>
    {
		Task<bool> CheckIfItemExistsAsync(Guid id);

		Task<IReadOnlyList<TItem>> GetAllItemsAsync();

		Task<TItem> GetItemByIdAsync(Guid id);

		Task<TItem> CreateItemAsync(TItem item);

		Task UpdateItemAsync(TItem item);

		Task DeleteItemAsync(Guid id);
	}
}
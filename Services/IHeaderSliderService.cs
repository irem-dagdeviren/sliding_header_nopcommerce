using Nop.Core;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Domain;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Services
{
    /// <summary>
    /// Store pickup point service interface
    /// </summary>
    public interface IHeaderSliderService
    {
        Task<IPagedList<SlidingText>> GetAllSlidingTextsAsync(int storeId = 0, int pageIndex = 0, int pageSize = int.MaxValue);

        Task<SlidingText> GetSlidingTextByIdAsync(int slidingTextId);

        Task InsertSlidingTextAsync(SlidingText slidingText);

        Task UpdateSlidingTextAsync(SlidingText slidingText);

        Task DeleteSlidingTextAsync(SlidingText slidingText);
    }
}
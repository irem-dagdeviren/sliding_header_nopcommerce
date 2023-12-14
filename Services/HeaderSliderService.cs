using Nop.Core;
using Nop.Data;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Domain;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Services
{ 
    public class HeaderSliderService : IHeaderSliderService {

    #region Fields

    private readonly IRepository<SlidingText> _slidingTextRepository;

    #endregion

    #region Ctor

    public HeaderSliderService(IRepository<SlidingText> slidingTextRepository)
    {
        _slidingTextRepository = slidingTextRepository;      
    }

    #endregion

    #region Methods

    public virtual async Task<IPagedList<SlidingText>> GetAllSlidingTextsAsync(int storeId = 0, int pageIndex = 0, int pageSize = int.MaxValue)
    {
        var rez = await _slidingTextRepository.GetAllAsync(query =>
        {
            if (storeId > 0)
                query = query.Where(text => text.WidgetId == storeId || text.WidgetId == 0);
            query = query.OrderBy(text => text.Title).ThenBy(text => text.Title);

            return query;
        });

        return new PagedList<SlidingText>(rez, pageIndex, pageSize);
    }
    public virtual async Task<SlidingText> GetSlidingTextByIdAsync(int slidingTextId)
    {
        return await _slidingTextRepository.GetByIdAsync(slidingTextId);
    }

    public virtual async Task InsertSlidingTextAsync(SlidingText slidingText)
    {
        await _slidingTextRepository.InsertAsync(slidingText, false);
    }

    public virtual async Task UpdateSlidingTextAsync(SlidingText slidingText)
    {
        await _slidingTextRepository.UpdateAsync(slidingText, false);    }

    public virtual async Task DeleteSlidingTextAsync(SlidingText slidingText)
    {
        await _slidingTextRepository.DeleteAsync(slidingText, false);       
    }

    #endregion
}
}
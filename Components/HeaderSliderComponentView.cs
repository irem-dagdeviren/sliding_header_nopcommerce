using Microsoft.AspNetCore.Mvc;
using Nop.Core.Caching;
using Nop.Core;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Models;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Services;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Components 
{
    public class HeaderSliderComponentView : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IHeaderSliderService _headerSliderService;

        public HeaderSliderComponentView(IStoreContext storeContext,
           IHeaderSliderService headerSliderService)
        {
            _storeContext = storeContext;
            _headerSliderService = headerSliderService;
        }
       
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            var store = await _storeContext.GetCurrentStoreAsync();
            foreach (var slidingtext in await _headerSliderService.GetAllSlidingTextsAsync(store.Id))
            {
                if(widgetZone  == slidingtext.Zone)
                {
                    var model = new PublicInfoModel
                    {
                        Id = slidingtext.Id,
                        StartDate = slidingtext.StartDate,
                        EndDate = slidingtext.EndDate,
                        IsDisabled = slidingtext.IsDisabled,
                        FontFamily = slidingtext.FontFamily,
                        FontSize = slidingtext.FontSize,
                        FontColor = slidingtext.FontColor,
                        WidgetHeight = slidingtext.WidgetHeight,
                        BackgroundColor = slidingtext.BackgroundColor,
                        AnimationTime = slidingtext.AnimationTime,
                        Title = slidingtext.Title,
                    };
                    return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/PublicInfo.cshtml", model);
                }
               
            }



            return Content("");
    
 
           
        }
    }
}

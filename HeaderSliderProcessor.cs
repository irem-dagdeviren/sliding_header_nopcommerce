using Nop.Core;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Components;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Services;
using Nop.Services.Cms;
using Nop.Services.Localization;
using Nop.Services.Plugins;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin
{
    public class HeaderSliderProcessor : BasePlugin, IWidgetPlugin
    {
        private readonly IWebHelper _webHelper;
        private readonly ILocalizationService _localizationService;
        private readonly IHeaderSliderService _headerSliderService;

        public bool HideInWidgetList => false;
        public HeaderSliderProcessor(
           IWebHelper webHelper,
           ILocalizationService localizationService,
           IHeaderSliderService headerSliderService)
        {
            _webHelper = webHelper;
            _localizationService = localizationService;
            _headerSliderService = headerSliderService;
        }

        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(HeaderSliderComponentView); 
        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        {
            var zones = new List<string>();

            foreach (var slidingtext in await _headerSliderService.GetAllSlidingTextsAsync())
            {

                zones.Add(slidingtext.Zone);
            }    
            return zones;
        }        

        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() + "Admin/HeaderSlider/Configure";
        }
     
        public override async Task InstallAsync()
        {
        
            await _localizationService.AddOrUpdateLocaleResourceAsync(new Dictionary<string, string>
            {
                ["Plugins.Widgets.HeaderSliderPlugin.StartDate"] = "Start Date",
                ["Plugins.Widgets.HeaderSliderPlugin.EndDate"] = "End Date",
                ["Plugins.Widgets.HeaderSliderPlugin.isDisabled"] = "Visibility",
                ["Plugins.Widgets.HeaderSliderPlugin.fontFamily"] = "Font Family",
                ["Plugins.Widgets.HeaderSliderPlugin.fontSize"] = "Font Size",
                ["Plugins.Widgets.HeaderSliderPlugin.fontColor"] = "Font Color",
                ["Plugins.Widgets.HeaderSliderPlugin.WidgetHeight"] = "Height of Widget",
                ["Plugins.Widgets.HeaderSliderPlugin.WidgetZone"] = "Widget Zone",
                ["Plugins.Widgets.HeaderSliderPlugin.BackgroundColor"] = "Background Color",
                ["Plugins.Widgets.HeaderSliderPlugin.Title"] = "Title for Header",
                ["Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidFontSize"] = "Font size must be greater than zero ",
                ["Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidWidgetHeight"] = "Widget height must be greater than font size",
                ["Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidEndDate"] = "end date must be greater than start date",
                ["Plugins.Widgets.HeaderSliderPlugin.Zone"] = "Display Zone",
                ["Plugins.Widgets.HeaderSliderPlugin.AnimationTime"] = "Time of Sliding"


            });

            await base.InstallAsync();
        }
    
        public override async Task UninstallAsync()
        {
            
            await _localizationService.DeleteLocaleResourcesAsync("Plugins.Widgets.HeaderSliderPlugin");

        }
       
       
      
       
    }
    
}
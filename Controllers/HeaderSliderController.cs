using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Domain;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Models;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Services;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Nop.Web.Framework.Mvc;
using Nop.Web.Framework.Models.Extensions;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Controllers
{
    [Area(AreaNames.Admin)]
    [AuthorizeAdmin]
    [AutoValidateAntiforgeryToken]
    public class HeaderSliderController : BasePluginController
    {
        #region Fields
        private readonly ILocalizationService _localizationService;
        private readonly INotificationService _notificationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;
        private readonly IHeaderSliderService _headerSliderService;


        #endregion

        #region Ctor

        public HeaderSliderController(
            ILocalizationService localizationService,
            INotificationService notificationService,
            IPermissionService permissionService,
            ISettingService settingService,
            IStoreContext storeContext,
            IHeaderSliderService headerSliderService)        {
            _localizationService = localizationService;
            _notificationService = notificationService;
            _permissionService = permissionService;
            _settingService = settingService;
            _storeContext = storeContext;
            _headerSliderService = headerSliderService;
        }

        #endregion

        #region Methods

        [AuthorizeAdmin]
        [Area(AreaNames.Admin)]
        public async Task<IActionResult> Configure()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();
            var model = new ConfigurationSearchModel();
            return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/Configure.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ConfigurationModel model)
        {
            if (!ModelState.IsValid)
                return await Configure();

            var slidingtext = new SlidingText
                {
                    Title = model.Title,
                    EndDate = model.EndDate,
                    WidgetHeight = model.WidgetHeight,
                    StartDate = model.StartDate,
                    IsDisabled = model.IsDisabled,
                    FontSize = model.FontSize,
                    FontColor = model.FontColor,
                    FontFamily = model.FontFamily,
                    BackgroundColor = model.BackgroundColor,
                    AnimationTime = model.AnimationTime,
                    Zone = model.Zone,
                };
                 await _headerSliderService.InsertSlidingTextAsync(slidingtext);
                RedirectToAction("Configure");

                return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/Create.cshtml", model);
            

        }
        public async Task<IActionResult> Create()
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();
            var model = new ConfigurationModel
            {
            };
            return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/Create.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            var slidingtext = await _headerSliderService.GetSlidingTextByIdAsync(id);
            if (slidingtext == null)
                return RedirectToAction("Configure");
        
            await _headerSliderService.DeleteSlidingTextAsync(slidingtext);

            return new NullJsonResult();
        }

        [HttpPost]
        public async Task<IActionResult> List(ConfigurationSearchModel searchModel)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageShippingSettings))
                return await AccessDeniedDataTablesJson();
                try
                {
                    var slidingtexts = await _headerSliderService.GetAllSlidingTextsAsync(pageIndex: searchModel.Page - 1,
                    pageSize: searchModel.PageSize);
                    var model = await new ConfigurationListModel().PrepareToGridAsync(searchModel, slidingtexts, () =>
                    {
                        return slidingtexts.SelectAwait(async slidingtext =>
                        {
                            var store = await _headerSliderService.GetSlidingTextByIdAsync(slidingtext.Id);

                            return new ConfigurationModel
                            {
                                Id = slidingtext.Id,
                                Title = slidingtext.Title,
                                StartDate = slidingtext.StartDate,    
                                EndDate = slidingtext.EndDate,
                                IsDisabled = slidingtext.IsDisabled,
                                FontColor = slidingtext.FontColor,
                                FontSize = slidingtext.FontSize,
                                FontFamily = slidingtext.FontFamily,
                                WidgetHeight = slidingtext.WidgetHeight,
                                BackgroundColor = slidingtext.BackgroundColor,
                                Zone = slidingtext.Zone,
                                AnimationTime = slidingtext.AnimationTime
                        };
                        });
                    });

                    return Json(model);

                }catch(Exception ex)
                {
                    return StatusCode(500);
                }
        }


        public async Task<IActionResult> Edit(int id)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            var slidingtext = await _headerSliderService.GetSlidingTextByIdAsync(id);
            if (slidingtext == null)
                return RedirectToAction("Configure");

            var model = new ConfigurationModel
            {
                Id = slidingtext.Id,
                Title = slidingtext.Title,
                StartDate = slidingtext.StartDate,
                EndDate = slidingtext.EndDate,
                IsDisabled = slidingtext.IsDisabled,
                FontColor = slidingtext.FontColor,
                FontSize = slidingtext.FontSize,
                FontFamily = slidingtext.FontFamily,
                WidgetHeight = slidingtext.WidgetHeight,
                BackgroundColor = slidingtext.BackgroundColor,
                Zone = slidingtext.Zone,
                AnimationTime = slidingtext.AnimationTime
            };  

                return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/Edit.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ConfigurationModel model)
        {
            if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
                return AccessDeniedView();

            if (!ModelState.IsValid)
                return await Edit(model.Id);

            var slidingtext = await _headerSliderService.GetSlidingTextByIdAsync(model.Id);
            if (slidingtext == null)
                return RedirectToAction("Configure");

            

            slidingtext.Title = model.Title;
            slidingtext.StartDate = model.StartDate;
            slidingtext.EndDate = model.EndDate;
            slidingtext.IsDisabled = model.IsDisabled;
            slidingtext.FontColor = model.FontColor;
            slidingtext.FontSize = model.FontSize;
            slidingtext.FontFamily = model.FontFamily;
            slidingtext.WidgetHeight = model.WidgetHeight;
            slidingtext.BackgroundColor = model.BackgroundColor;
            slidingtext.AnimationTime = model.AnimationTime;
            slidingtext.Zone = model.Zone;
            await _headerSliderService.UpdateSlidingTextAsync(slidingtext);
         
            ViewBag.RefreshPage = true;

            return View("~/Plugins/Widgets.HeaderSliderPlugin/Views/Edit.cshtml", model);
        }


        #endregion
    }

    
}


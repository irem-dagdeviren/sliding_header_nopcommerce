using FluentValidation;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Models;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;


namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Validators
{
    public class HeaderSliderContentValidator : AbstractValidator<ConfigurationModel>
    {
        public HeaderSliderContentValidator(ILocalizationService localizationService)
        {
            RuleFor(model => ParseFontSize(model.WidgetHeight))
             .GreaterThan(model => ParseFontSize(model.FontSize))
                .WithMessageAwait(localizationService.GetResourceAsync("Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidWidgetHeight"));
            RuleFor(model => model.EndDate)
             .GreaterThan(model => model.StartDate)
                .WithMessageAwait(localizationService.GetResourceAsync("Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidEndDate"));
            RuleFor(model => ParseFontSize(model.FontSize))
             .GreaterThan(0)
                .WithMessageAwait(localizationService.GetResourceAsync("Plugins.Widgets.HeaderSliderPlugin.Configuration.Fields.InvalidFontSize"));

        }
        public int ParseFontSize(string fontSize)
        {         
            if (int.TryParse(fontSize, out var parsedFontSize))
            {
                return parsedFontSize;
            }
            throw new ArgumentException("Invalid FontSize format.");
        }
    }

   

   
}
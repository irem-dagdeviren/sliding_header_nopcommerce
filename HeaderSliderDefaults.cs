using Nop.Core.Caching;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin
{
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public class HeaderSliderDefaults
    {
        /// <summary>
        /// Gets the plugin system name
        /// </summary>
        public static string SystemName => "Widgets.HeaderSliderPlugin";


        /// <summary>
        /// Gets the configuration route name
        /// </summary>
        public static string ConfigurationRouteName => "Plugin.Widgets.HeaderSlider.Configure";

        #region Caching

        /// <summary>
        /// Gets the cache key for configuration
        /// </summary>
        /// <remarks>
        /// {0} : configuration identifier
        /// </remarks>
        public static CacheKey ConfigurationCacheKey => new("Nop.Plugin.Widgets.HeaderSliderPlugin.Configuration-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for configurations
        /// </summary>
        /// <remarks>
        /// {0} : store identifier
        /// </remarks>
        public static CacheKey ConfigurationsCacheKey => new("Nop.Plugin.Widgets.HeaderSliderPlugin.Configurations-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for custom events
        /// </summary>
        public static CacheKey CustomEventsCacheKey => new("Nop.Plugin.Widgets.HeaderSliderPlugin.CustomEvents-{0}", PrefixCacheKey);

        /// <summary>
        /// Gets the cache key for widget zones
        /// </summary>
        public static CacheKey WidgetZonesCacheKey => new("Nop.Plugin.Widgets.HeaderSliderPlugin.WidgetZones", PrefixCacheKey);

        /// <summary>
        /// Gets the prefix key to clear cache
        /// </summary>
        public static string PrefixCacheKey => "Nop.Plugin.Widgets.HeaderSliderPlugin";

        #endregion




     
    }
}
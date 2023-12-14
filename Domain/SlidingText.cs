using Nop.Core;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Domain
{
    public class SlidingText : BaseEntity
    {
        public int WidgetId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDisabled { get; set; }
        public string? FontSize { get; set; }
        public string? FontColor { get; set; }
        public string? FontFamily { get; set; }
        public string? WidgetHeight { get; set; }
        public string? BackgroundColor { get; set; }
        public string Zone { get; set; }
        public string AnimationTime { get; set; }

    }
}
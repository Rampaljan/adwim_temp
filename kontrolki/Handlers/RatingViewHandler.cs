using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using kontrolki.Controls;

#if WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.RatingControl;
#elif ANDROID
using PlatformView = Android.Widget.RatingBar;
#endif

namespace kontrolki.Handlers;

public partial class RatingViewHandler : ViewHandler<RatingView, PlatformView>
{
    public static readonly IPropertyMapper<RatingView, RatingViewHandler> PropertyMapper =
    new PropertyMapper<RatingView, RatingViewHandler>(ViewMapper)
    {
        [nameof(RatingView.Value)] = MapValue
    };
}

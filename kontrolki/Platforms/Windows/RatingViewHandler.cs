using System;
using System.Collections.Generic;
using System.Text;
using kontrolki.Controls;
using Microsoft.UI.Xaml.Controls;

namespace kontrolki.Handlers
{
    public partial class RatingViewHandler
    {
        protected override RatingControl CreatePlatformView()
        {
            return new RatingControl()
            {
                MaxRating = 5
            };
        }

        private static void MapValue(RatingViewHandler handler, RatingViewHandler view)
        => handler.CreatePlatformView().Value = view.Value;

    }
}

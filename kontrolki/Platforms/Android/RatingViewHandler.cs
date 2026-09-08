using System;
using System.Collections.Generic;
using System.Text;
using Android.Widget;
using kontrolki.Controls;

namespace kontrolki.Handlers
{
    public partial class RatingViewHandler
    {
        protected override RatingBar CreatePlatformView()
        {
            return new RatingBar(Context)
            {
                NumStars = 5,
                StepSize = 1
            }
        }


    }
}

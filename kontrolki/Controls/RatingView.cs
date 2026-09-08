using System;
using System.Collections.Generic;
using System.Text;

namespace kontrolki.Controls
{
    public class RatingView : View
    {
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(
                nameof(Value),
                typeof(int),
                typeof(RatingView),
                0d,
                defaultBindingMode: BindingMode.TwoWay);

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

    }
}

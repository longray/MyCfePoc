namespace ModernUI.Windows.Converters
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Media;

    using Microsoft.Windows.Controls;

    /// <summary>
    /// Converts a int value to a Row Background(even: background, odd: alerrow)
    /// </summary>
    public class RowBackgroundConverter
        : IValueConverter
    {
        // Fields
        private readonly List<object> _values = new List<object>();

        // Methods
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = (RelativeSource)parameter;
            
            if ((this._values.Count <= 0) || !(value is int))
            {
                return DependencyProperty.UnsetValue;
            }
            int num = ((int)value) % this._values.Count;
            if (num < 0)
            {
                num += this._values.Count;
            }
            return this._values[num];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return this._values.IndexOf(value);
        }

        // Properties
        public IList Values
        {
            get
            {
                return this._values;
            }
        }

    }
}

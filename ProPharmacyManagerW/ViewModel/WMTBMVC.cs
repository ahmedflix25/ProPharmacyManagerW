﻿using System;
using System.Windows;
using System.Windows.Data;

namespace ProPharmacyManagerW.ViewModel
{
    /// <summary>
    /// WaterMarkTextBox MultiVisibilityConverter
    /// </summary>
    class WMTBMVC : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = (string)values[0];
            return text == string.Empty ? Visibility.Visible : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return new object[0];
        }
    }
}

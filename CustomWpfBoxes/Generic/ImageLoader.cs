using System;
using System.Windows.Media;

namespace CustomWpfBoxes.Generic
{
    class ImageLoader
    {
        public static ImageSource LoadFromResource(string resourcePath)
        {
            string packUri = $"pack://application:,,,/CustomWpfBoxes;component{resourcePath}";
            return new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }
    }
}

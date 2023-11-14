using System.Windows.Media;

namespace CustomWpfBoxes.Generic
{
    public class BrushColor
    {
        public static SolidColorBrush FromHex(string hexColorString)
        {
            return (SolidColorBrush)new BrushConverter().ConvertFrom(hexColorString);
        }

        public static SolidColorBrush FromRgb(byte r, byte g, byte b)
        {
            return new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}

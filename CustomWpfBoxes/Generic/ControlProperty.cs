using MaterialDesignBoxes;
using System.Windows;

namespace CustomWpfBoxes.Generic
{
    class ControlProperty
    {
        public static Style SetStyle(MessageBoxWindow messageBox, string styleKey)
        {
            return messageBox.FindResource(styleKey) as Style;
        }
    }
}

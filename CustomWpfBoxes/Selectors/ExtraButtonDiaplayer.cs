using CustomWpfBoxes.Models;
using MaterialDesignBoxes;
using System.Collections.Generic;
using System.Windows;

namespace CustomWpfBoxes.Selectors
{
    public class ExtraButtonsDisplayer
    {
        private readonly IList<IExtraButtonDisplay> _displayRules;

        public ExtraButtonsDisplayer()
        {
            _displayRules = new List<IExtraButtonDisplay>() { new NoExtraButton(), new PasteExtraButton(), new ClearExtraButton(), new AllExtraButton() };
        }

        public void Display(InputBoxExtraButton extraButton, InputBoxWindow inputBox)
        {
            foreach (IExtraButtonDisplay displayRule in _displayRules)
            {
                if (displayRule.ExtraButton == extraButton)
                {
                    displayRule.Display(inputBox);
                    break;
                }
            }
        }
    }

    public interface IExtraButtonDisplay
    {
        void Display(InputBoxWindow inputBox);

        InputBoxExtraButton ExtraButton { get; }
    }

    public class NoExtraButton : IExtraButtonDisplay
    {
        public void Display(InputBoxWindow inputBox)
        {
            inputBox.ButtonPaste.Visibility = Visibility.Collapsed;
            inputBox.ButtonClear.Visibility = Visibility.Collapsed;
            inputBox.InputBoxButtons.HorizontalAlignment = HorizontalAlignment.Right;
        }

        public InputBoxExtraButton ExtraButton => InputBoxExtraButton.None;
    }

    public class PasteExtraButton : IExtraButtonDisplay
    {
        public void Display(InputBoxWindow inputBox)
        {
            inputBox.ButtonClear.Visibility = Visibility.Collapsed;
        }

        public InputBoxExtraButton ExtraButton => InputBoxExtraButton.Paste;
    }

    public class ClearExtraButton : IExtraButtonDisplay
    {
        public void Display(InputBoxWindow inputBox)
        {
            inputBox.ButtonPaste.Visibility = Visibility.Collapsed;
            inputBox.InputBoxButtons.HorizontalAlignment = HorizontalAlignment.Right;
        }

        public InputBoxExtraButton ExtraButton => InputBoxExtraButton.Clear;
    }

    public class AllExtraButton : IExtraButtonDisplay
    {
        public void Display(InputBoxWindow inputBox) { }

        public InputBoxExtraButton ExtraButton => InputBoxExtraButton.All;
    }


}

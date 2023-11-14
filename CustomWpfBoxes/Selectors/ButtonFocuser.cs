using CustomWpfBoxes.Generic;
using CustomWpfBoxes.Models;
using MaterialDesignBoxes;
using System.Collections.Generic;

namespace CustomWpfBoxes.Selectors
{
    public class ButtonsFocuser
    {
        private readonly IList<IButtonsFocus> _focusRules;

        public ButtonsFocuser()
        {
            _focusRules = new List<IButtonsFocus>() { new NoneFocus(), new Button1Focus(), new Button2Focus(), new Button3Focus() };
        }

        public void Focus(MessageBoxFocus button, MessageBoxWindow messageBox)
        {
            foreach (IButtonsFocus focusRule in _focusRules)
            {
                if (focusRule.Button == button)
                {
                    focusRule.Focus(messageBox);
                    break;
                }
            }
        }
    }

    public interface IButtonsFocus
    {
        void Focus(MessageBoxWindow messageBox);

        MessageBoxFocus Button { get; }
    }

    public class NoneFocus : IButtonsFocus
    {
        public void Focus(MessageBoxWindow messageBox) { }

        public MessageBoxFocus Button => MessageBoxFocus.None;
    }

    public class Button1Focus : IButtonsFocus
    {
        public void Focus(MessageBoxWindow messageBox)
        {
            messageBox.Button1.Style = ControlProperty.SetStyle(messageBox, "FocusedButton");
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button1;
    }

    public class Button2Focus : IButtonsFocus
    {
        public void Focus(MessageBoxWindow messageBox)
        {
            messageBox.Button2.Style = ControlProperty.SetStyle(messageBox, "FocusedButton");
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button2;
    }

    public class Button3Focus : IButtonsFocus
    {
        public void Focus(MessageBoxWindow messageBox)
        {
            messageBox.Button3.Style = ControlProperty.SetStyle(messageBox, "FocusedButton");
        }

        public MessageBoxFocus Button => MessageBoxFocus.Button3;
    }
}

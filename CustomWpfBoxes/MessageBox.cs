using CustomWpfBoxes.Models;
using CustomWpfBoxes.Selectors;
using System.Windows;
using System.Windows.Controls;
using MessageBoxButton = CustomWpfBoxes.Models.MessageBoxButton;

namespace CustomWpfBoxes
{
    public sealed partial class MessageBox
    {
        private static readonly ButtonsFocuser _buttonsFocuser = new ButtonsFocuser();
        private static readonly IconDisplayer _iconDisplayer = new IconDisplayer();

        public static MessageBoxOutcome Show(
            string messageText,
            string title = "Message Box",
            MessageBoxButton buttons = MessageBoxButton.OkOnly,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            MessageBoxToolsVisibility tools = MessageBoxToolsVisibility.Hidden,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetDefaultControls(messageBox, buttons, icon, focus, tools, checkBox);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        private static void SetDefaultControls(
            MessageBoxWindow messageBox,
            MessageBoxButton buttons,
            MessageBoxIcon icon,
            MessageBoxFocus focus,
            MessageBoxToolsVisibility tools,
            string checkBox)
        {
            var buttonDisplayer = new ButtonsDisplayer();
            buttonDisplayer.Display(buttons, messageBox);
            _iconDisplayer.Display(icon, messageBox);
            _buttonsFocuser.Focus(focus, messageBox);
            if (tools == MessageBoxToolsVisibility.Hidden)
                messageBox.MessageBoxTools.Visibility = Visibility.Collapsed;
            CheckBoxHandler(checkBox, messageBox);
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            MessageBoxToolsVisibility tools = MessageBoxToolsVisibility.Hidden,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, focus, tools, checkBox, button1);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            string button2,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            MessageBoxToolsVisibility tools = MessageBoxToolsVisibility.Hidden,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, focus, tools, checkBox, button1, button2);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        public static MessageBoxOutcome Show(
            string messageText,
            string title,
            string button1,
            string button2,
            string button3,
            MessageBoxIcon icon = MessageBoxIcon.Default,
            MessageBoxFocus focus = MessageBoxFocus.None,
            MessageBoxToolsVisibility tools = MessageBoxToolsVisibility.Hidden,
            string checkBox = "")
        {
            MessageBoxOutcome outcome = new MessageBoxOutcome();

            using (MessageBoxWindow messageBox = new MessageBoxWindow())
            {
                messageBox.Width = 500;
                messageBox.Title = title;
                messageBox.MessageBoxTitle.Text = title;
                messageBox.MessageBoxText.Text = messageText;
                SetCustomControls(messageBox, icon, focus, tools, checkBox, button1, button2, button3);
                outcome = messageBox.Outcome;
                messageBox.ShowDialog();
            }

            return outcome;
        }

        private static void SetCustomControls(
            MessageBoxWindow messageBox,
            MessageBoxIcon icon,
            MessageBoxFocus focus,
            MessageBoxToolsVisibility tools,
            string checkBox,
            string button1,
            string button2 = "",
            string button3 = "")
        {
            var buttonsDisplayer = new CustomButtonsDisplayer(messageBox, button1, button2, button3);
            buttonsDisplayer.Display();
            _iconDisplayer.Display(icon, messageBox);
            _buttonsFocuser.Focus(focus, messageBox);
            if (tools == MessageBoxToolsVisibility.Hidden)
                messageBox.MessageBoxTools.Visibility = Visibility.Collapsed;
            CheckBoxHandler(checkBox, messageBox);
        }

        private static void CheckBoxHandler(string checkBox, MessageBoxWindow messageBox)
        {
            if (string.IsNullOrEmpty(checkBox))
            {
                messageBox.MessageCheckBox.Visibility = Visibility.Collapsed;
                Grid.SetRowSpan(messageBox.MessageBoxScrollViewer, 2);
            }
            else
                messageBox.MessageCheckBox.Content = checkBox;
        }
    }
}

using CustomWpfBoxes.Generic;
using CustomWpfBoxes.Models;
using System.Collections.Generic;

namespace CustomWpfBoxes.Selectors
{
    public class IconDisplayer
    {
        private readonly IList<IIconDisplay> _displayRules;

        public IconDisplayer()
        {
            _displayRules = new List<IIconDisplay>() { new NoIcon(), new Default(), new Information(), new Question(), new Warning(), new Error() };
        }

        public void Display(MessageBoxIcon icon, MessageBoxWindow messageBox)
        {
            foreach (IIconDisplay displayRule in _displayRules)
            {
                if (displayRule.Icon == icon)
                {
                    displayRule.Display(messageBox);
                    break;
                }
            }
        }
    }

    public interface IIconDisplay
    {
        void Display(MessageBoxWindow messageBox);

        MessageBoxIcon Icon { get; }
    }

    public class NoIcon : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Visibility = System.Windows.Visibility.Collapsed;
        }

        public MessageBoxIcon Icon => MessageBoxIcon.None;
    }

    public class Default : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Source = ImageLoader.LoadFromResource("/Icons/message.png");
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Default;
    }

    public class Information : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Source = ImageLoader.LoadFromResource("/Icons/information.png");
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Information;
    }

    public class Question : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Source = ImageLoader.LoadFromResource("/Icons/question.png");
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Question;
    }

    public class Warning : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Source = ImageLoader.LoadFromResource("/Icons/warning.png");
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Warning;
    }

    public class Error : IIconDisplay
    {
        public void Display(MessageBoxWindow messageBox)
        {
            messageBox.MessageBoxIcon.Source = ImageLoader.LoadFromResource("/Icons/error.png");
        }

        public MessageBoxIcon Icon => MessageBoxIcon.Error;
    }
}

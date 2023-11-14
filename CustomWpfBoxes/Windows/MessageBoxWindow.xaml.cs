using CustomWpfBoxes.Generic;
using CustomWpfBoxes.Models;
using CustomWpfBoxes.Selectors;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using MessageBoxResult = CustomWpfBoxes.Models.MessageBoxResult;

namespace CustomWpfBoxes
{
    /// <summary>
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class MessageBoxWindow : IDisposable
    {
        public MessageBoxOutcome Outcome { get; set; }

        public MessageBoxWindow()
        {
            InitializeComponent();
            Outcome = new MessageBoxOutcome();
        }
        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            SetMessageBoxOutcome(Button1);
            Close();
        }
        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            SetMessageBoxOutcome(Button2);
            Close();
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            SetMessageBoxOutcome(Button3);
            Close();
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        private void MessageBoxChrome_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SetMessageBoxOutcome(Button button)
        {
            var resultSetter = new ResultSetter();
            resultSetter.SetResult(this, button.Content.ToString(), button.Name);

            if ((bool)MessageCheckBox.IsChecked)
                Outcome.Checkbox = MessageBoxCheckbox.Checked;
            else
                Outcome.Checkbox = MessageBoxCheckbox.Unchecked;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Outcome.Result = MessageBoxResult.Cancel;
            Close();
        }

        private void CopyToClipboardAsText_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(MessageBoxText.Text);
        }

        private void CopyToClipboardAsImage_Click(object sender, RoutedEventArgs e)
        {
            WindowSnapshot.CopyToClipboard(new WindowInteropHelper(this).Handle);
        }
    }
}

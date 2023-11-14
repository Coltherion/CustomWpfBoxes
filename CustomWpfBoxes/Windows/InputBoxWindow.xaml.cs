using System;
using System.Windows;

namespace MaterialDesignBoxes
{
    /// <summary>
    /// Interaction logic for MessageBoxWindow.xaml
    /// </summary>
    public partial class InputBoxWindow : IDisposable
    {

        public string Input { get; set; }

        public string SelectedItem { get; set; }

        public InputBoxWindow()
        {
            InitializeComponent();
            Input = string.Empty;
            SelectedItem = string.Empty;
            InputBoxField.Focus();
        }
        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            Input = InputBoxField.Text;
            SelectedItem = InputBoxCombobox.Text;
            Close();
        }
        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        private void ButtonPaste_OnClick(object sender, RoutedEventArgs e)
        {
            if (InputBoxField.AcceptsReturn == false && InputBoxField.TextWrapping == TextWrapping.NoWrap
                && Clipboard.GetText().Contains("\r\n"))
                InputBoxField.Text = Clipboard.GetText().Substring(0, Clipboard.GetText().IndexOf("\r\n"));
            else
                InputBoxField.Text = Clipboard.GetText();
            InputBoxField.Focus();
        }

        private void InputBoxHeader_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            InputBoxField.Clear();
            InputBoxField.Focus();
        }
    }
}

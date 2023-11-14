using CustomWpfBoxes.Models;
using MaterialDesignBoxes;
using System.Windows;
using MessageBox = CustomWpfBoxes.MessageBox;
using MessageBoxButton = CustomWpfBoxes.Models.MessageBoxButton;

namespace CustomWpfBoxesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowSimpleMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var outcome = MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Warning, MessageBoxFocus.Button1, MessageBoxToolsVisibility.Visible);
            //var outcome = MessageBox.Show($"This is a simple message.", "Checkbox Message", checkBox: "This is a checkbox");
            //var result = MessageBox.Show($"This is a message.", "Checkbox Message", checkBox: "This is a checkbox");
        }

        private void ShowSimpleRTLMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show($"This is a simple message.", "Custom Title",
            //    MessageBoxButton.OkOnly, MessageBoxIcon.Question, checkBox: "Mark as complete");
            var outcome = MessageBox.Show("This is a message.", "Title", button1: "Help", button2: "Submit", button3: "Quit", MessageBoxIcon.Information);
            //var outcome = MessageBox.Show("This is a simple message.", "Custom Buttons", button1: "Help", button2: "Submit", button3: "Quit", tools: MessageBoxToolsVisibility.Visible, checkBox: "Set all option to true");
        }

        private void ShowWarningMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
                MessageBoxButton.YesNoCancel, MessageBoxIcon.Warning, MessageBoxFocus.Button2, tools: MessageBoxToolsVisibility.Visible, checkBox: "Mark as complete");
            //var result = MessageBox.Visible($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
            //    MessageBoxButton.YesNoCancel, MessageBoxIcon.Warning, MessageBoxFocus.Button2);
        }

        private void ShowErrorMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
                MessageBoxButton.OkOnly, MessageBoxIcon.Error, checkBox: "Mark as complete");
            //var result = MessageBox.Visible($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
            //    CustomWpfBoxes.Models.MessageBoxButton.OkCancel, MessageBoxIcon.Warning);
            //var result = InputBox.Visible("Please choose item:", new string[] { "Item111111111111111111111111111111111111111111111111111111111111111111111", "Item2", "Item3" });
        }

        private void ShowMessageBoxWithCancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
            //    MessageBoxButton.OkOnly, MessageBoxIcon.Default, checkBox: "Mark as complete");
            //var result = InputBox.Show("Please enter your name:", "Input", "This is default value", InputBoxOption.MultiLine, InputBoxExtraButton.All);
            var result = InputBox.Show("Please choose item:", new string[] { "Item1", "Item2", "Item3" });
        }

        private void ShowCustomMessageBox_OnClick(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show($"This is a simple message\n\nIs'nt it cool !!\n.\n.\nYou could even scroll!!!\nd\no\no\no\no\no\nw\nn", "Custom Title",
            //    MessageBoxButton.OkOnly, checkBox: "Done");
            var result = InputBox.Show("Plese enter a name:", "Input Box", string.Empty, InputBoxOption.SingleLine, InputBoxExtraButton.All);
        }
    }
}

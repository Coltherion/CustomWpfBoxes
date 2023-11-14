using CustomWpfBoxes.Models;
using CustomWpfBoxes.Selectors;
using System.Windows.Controls;

namespace MaterialDesignBoxes
{
    public sealed partial class InputBox
    {
        private static readonly ExtraButtonsDisplayer _extraButtonsDisplayer = new ExtraButtonsDisplayer();

        public static string Show(
            string query,
            string title = "Input Box",
            string defaultInput = "",
            InputBoxOption option = InputBoxOption.SingleLine,
            InputBoxExtraButton extraButton = InputBoxExtraButton.None)
        {
            string input = string.Empty;

            using (InputBoxWindow inputBox = new InputBoxWindow())
            {
                inputBox.InputBoxCombobox.Visibility = System.Windows.Visibility.Collapsed;
                inputBox.InputBoxQuery.Text = query;
                inputBox.InputBoxTitle.Text = title;
                inputBox.InputBoxField.Text = defaultInput;
                SetInputBoxOption(option, inputBox);
                _extraButtonsDisplayer.Display(extraButton, inputBox);
                inputBox.ShowDialog();
                input = inputBox.Input;
            }

            return input;
        }

        private static void SetInputBoxOption(InputBoxOption option, InputBoxWindow inputBox)
        {
            if (option == InputBoxOption.MultiLine)
            {
                inputBox.InputBoxField.AcceptsReturn = true;
                inputBox.InputBoxField.TextWrapping = System.Windows.TextWrapping.Wrap;
                inputBox.InputBoxField.MinHeight = 100;
                inputBox.InputBoxField.VerticalContentAlignment = System.Windows.VerticalAlignment.Top;
                inputBox.InputBoxField.ToolTip = string.Empty;
            }
        }

        public static string Show(
           string query,
           string[] items,
           string title = "Input Box")
        {
            string input = string.Empty;

            using (InputBoxWindow inputBox = new InputBoxWindow())
            {
                inputBox.InputBoxField.Visibility = System.Windows.Visibility.Collapsed;
                _extraButtonsDisplayer.Display(InputBoxExtraButton.None, inputBox);
                inputBox.InputBoxQuery.Text = query;
                inputBox.InputBoxTitle.Text = title;
                PopulateCombobox(items, inputBox.InputBoxCombobox);
                inputBox.ShowDialog();
                input = inputBox.SelectedItem;
            }

            return input;
        }
        private static void PopulateCombobox(string[] items, ComboBox comboBox)
        {
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }
    }
}

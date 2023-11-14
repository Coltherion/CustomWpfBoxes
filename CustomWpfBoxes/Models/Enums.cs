namespace CustomWpfBoxes.Models
{
    public enum MessageBoxButton
    {
        OkOnly,
        OkCancel,
        YesNo,
        YesNoCancel
    }

    public enum MessageBoxFocus
    {
        None,
        Button1,
        Button2,
        Button3
    }

    public enum MessageBoxIcon
    {
        None,
        Default,
        Information,
        Question,
        Warning,
        Error
    }

    public enum MessageBoxResult
    {
        OK,
        Cancel,
        Yes,
        No,
        Button1,
        Button2,
        Button3
    }

    public enum MessageBoxCheckbox
    {
        Unchecked,
        Checked
    }

    public enum MessageBoxToolsVisibility
    {
        Visible,
        Hidden
    }

    public enum InputBoxOption
    {
        SingleLine,
        MultiLine
    }

    public enum InputBoxExtraButton
    {
        None,
        Paste,
        Clear,
        All
    }
}

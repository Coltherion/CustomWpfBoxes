# WPF Material Message Box

A WPF Message Box implementing material design

[![Release](https://img.shields.io/github/release/Coltherion/CustomWpfBoxes.svg)](https://github.com/Coltherion/CustomWpfBoxes/releases/latest?style=for-the-badge)

![Nuget](https://img.shields.io/nuget/v/CustomWpfBoxes)

![Nuget](https://img.shields.io/nuget/dt/CustomWpfBoxes?label=nuget%20downloads)

## :sparkle: Main Features

The message box has the following custom features:

:white_check_mark: Message box can contain checkbook

:white_check_mark: Custom names for buttons (1-3 buttons)

:white_check_mark: Utilities to copy message box text or entire window as image to clipboard 

:white_check_mark: Scrollable message box content

:white_check_mark: Input box uses classical text input or combobox input

:white_check_mark: Button for adding clipboard content into input box

## :sparkle: Installing

:arrow_forward: [Download from Nuget ⤵](https://www.nuget.org/packages/CustomWpfBoxes/)

:arrow_forward: Install from Package manager Console

```sh
$ Install-Package CustomWpfBoxes
```

Or, if using `dotnet`

```sh
$ dotnet add package CustomWpfBoxes
```

## :sparkle: Usage (Screenshots)

> add using statement

```c#
using MaterialDesignBoxes;
```

> Using a default message box

```c#
MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, MessageBoxFocus.Button1, MessageBoxToolsVisibility.Visible);
```

or if you need the result

```c#
var outcome = MessageBox.Show($"This is a message.", "Custom Title", MessageBoxButton.OkOnly, MessageBoxIcon.Information, MessageBoxFocus.Button1, MessageBoxToolsVisibility.Visible);
MessageBoxResult result = outcome.Result;
if (result == MessageBoxResult.OK);
```

![Default Message](https://raw.githubusercontent.com/Coltherion/CustomWpfBoxes/main/Screenshots/CustomButtonsMessageBox.png)

> Using a message box with checkbox

```c#
var result = MessageBox.Show($"This is a message.", "Checkbox Message", checkBox: "This is a checkbox");
MessageBoxCheckbox checkbox = outcome.Checkbox;
if (checkbox == MessageBoxCheckbox.Checked)
```

![Message box with checkbox](https://raw.githubusercontent.com/Coltherion/CustomWpfBoxes/main/Screenshots/CheckboxMessageBox.png)

> Using a message with custom buttons (1-3 custom bottons)

```c#
MessageBox.Show("This is a message.", "Title", button1: "Done");
MessageBox.Show("This is a message.", "Title", button1: "Apply", button2: "Exit");
var outcome = MessageBox.Show("This is a message.", "Title", button1: "Help", button2: "Submit", button3: "Quit", MessageBoxIcon.Information);
if (outcome.Result == MessageBoxResult.Button1);
```

![Message box with custom buttons](https://raw.githubusercontent.com/Coltherion/CustomWpfBoxes/main/Screenshots/CustomButtonsMessageBox.png)

> Using a text input box

```c#
string result = InputBox.Show("Plese enter a name:", "Input Box", string.Empty, InputBoxOption.SingleLine, InputBoxExtraButton.All);
```

![Text input box](https://raw.githubusercontent.com/Coltherion/CustomWpfBoxes/main/Screenshots/TextInputBox.png)

> Using combobox input box

```c#
var result = InputBox.Show("Please choose item:", new string[] { "Item1", "Item2", "Item3" });
```

![Combobox input box](https://raw.githubusercontent.com/Coltherion/CustomWpfBoxes/main/Screenshots/ComboboxInputBox.png)

## :sparkle: Sources used

Icon source https://icon-icons.com/

## :sparkle: Contributing to this project

- You could always contact me through Email for any feature or issue. :star:

- You need [Visual Studio 2015 Community/Enterprise Edition](https://www.visualstudio.com/) (upwards) to build and test the solution.

---

## :sparkle: Licence

The MIT License (MIT)

Copyright (c) 2023, Coltherion

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

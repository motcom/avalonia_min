using Avalonia;
using Avalonia.Controls;

namespace avalonia_textbox;

public class MainWindow : Window
{
    public MainWindow()
    {
        Width = 360;
        Height = 120;

        Content = new TextBox
        {
            Text = "Hello, Avalonia!",
            Width = 240,
            Margin = new Thickness(16)
        };
    }
}

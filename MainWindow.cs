using Avalonia;
using Avalonia.Controls;

namespace avalonia_min;

public class MainWindow : Window
{
    public MainWindow()
    {
        Width = 360;
        Height = 120;


        // Create
        Label labelSrcPath = Ui.CreateLabel("SrcPath");
        TextBox tbSrcPath = Ui.CreateTextBox();
        Button btnGetSrcPath = Ui.CreateButton("Get");


        // Layout
        Grid gridGetPath = new Grid
        {
            ColumnDefinitions = ColumnDefinitions.Parse("Auto,*,Auto"),
            RowDefinitions = RowDefinitions.Parse("Auto"),
        };
        Grid.SetColumn(labelSrcPath, 0);
        Grid.SetColumn(tbSrcPath, 1);
        Grid.SetColumn(btnGetSrcPath, 2);

        gridGetPath.Children.Add(labelSrcPath);
        gridGetPath.Children.Add(tbSrcPath);
        gridGetPath.Children.Add(btnGetSrcPath);

        Content = gridGetPath;
    }
}

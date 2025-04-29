using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class Window3 : Window
{
    
    public Window3()
    {
        InitializeComponent();
    }
    public Window3(string a)
    {
        
        InitializeComponent();
        error.Text = a;
    }


    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}
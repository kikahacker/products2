using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1;

public partial class Window4 : Window
{
    busket busk;
    listTovars d;
    public Window4()
    {
        InitializeComponent();
        nado1.ItemsSource = null;
        if (busk != null)
        {
            nado1.ItemsSource = busk.list;
        }
        double x = 0;
        foreach (tovarsInBusket t in busk.list)
        {
            x += t.price;
        }
        sum.Text = x.ToString();
    }
    public Window4(busket bus,listTovars b)
    {
        busk = bus;
        d = b;
        InitializeComponent();
        nado1.ItemsSource = busk.list;
        double x = 0;
        foreach (tovarsInBusket t in busk.list)
        {
            x += t.price*t.kolvo;
        }
        sum.Text = x.ToString();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new Window1(d,busk).Show();
        Close();
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

    }

    private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

    }
}

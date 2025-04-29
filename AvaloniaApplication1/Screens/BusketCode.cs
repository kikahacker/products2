using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.Screens;

namespace AvaloniaApplication1;

public partial class Window4 : Window
{
    BusketClass busk;
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
    public Window4(BusketClass bus,listTovars b)
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

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//кнопка плюс в корзине
    {
        if (sender is Button button)
        {
            tovarsInBusket tovar = (tovarsInBusket)button.DataContext;
            foreach(tovarsInBusket Tovar in busk.list)
            {
                if (tovar.name == Tovar.name)
                {
                    Tovar.kolvo += 1;
                }
                foreach(Tovars a in d.listik)
                {
                    if(Tovar.name == a.name)
                    {
                        a.kolichestvo -= 1;
                    }
                }
            }
            nado1.ItemsSource = null;
            nado1.ItemsSource = busk.list;
            double x = 0;
            foreach (tovarsInBusket t in busk.list)
            {
                x += t.price * t.kolvo;
            }
            sum.Text = null;
            sum.Text = x.ToString();
        }
    }

    private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)//кнопка минус в корзине
    {
        if (sender is Button button)
        {
            tovarsInBusket tovar = (tovarsInBusket)button.DataContext;
            foreach (tovarsInBusket Tovar in busk.list)
            {
                if (tovar.name == Tovar.name)
                {
                    Tovar.kolvo -= 1;
                }
                foreach (Tovars a in d.listik)
                {
                    if (Tovar.name == a.name)
                    {
                        a.kolichestvo += 1;
                    }
                }
            }
            nado1.ItemsSource = null;
            nado1.ItemsSource = busk.list;
            double x = 0;
            foreach (tovarsInBusket t in busk.list)
            {
                x += t.price * t.kolvo;
            }
            sum.Text = null;
            sum.Text = x.ToString();
        }
    }
}

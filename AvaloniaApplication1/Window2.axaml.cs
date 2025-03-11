using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using static AvaloniaApplication1.MainWindow;
using System.Collections.ObjectModel;
using System;

namespace AvaloniaApplication1;

public partial class Window2 : Window
{
    private listTovars WW;
    private ObservableCollection<listTovars> ww;

    public Window2()
    {
        InitializeComponent();
    }
    public Window2(listTovars a, ObservableCollection<listTovars> ww)
    {
        InitializeComponent();
        WW = a;
        this.ww = ww;
        Name.Text = WW.name;
        Price.Text = WW.price.ToString();
        kolvo.Text = WW.kolichestvo.ToString();
        Discription.Text = WW.discr;

    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        WW.name = Name.Text;
        WW.price = Convert.ToDouble(Price.Text);
        WW.discr = Discription.Text;
        WW.kolichestvo = Convert.ToInt32(kolvo.Text);
        new Window1(ww).Show();
        Close();
        
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new Window1(ww).Show();
        Close();
    }
    
}
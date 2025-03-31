using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Tmds.DBus.Protocol;
using static AvaloniaApplication1.MainWindow;

namespace AvaloniaApplication1;

public partial class Window1 : Window
{
    listTovars b;
    busket a = new();
     public Window1()
     {
        InitializeComponent();
        nado.ItemsSource = null;
        nado.ItemsSource = b.listik;
    }
    public Window1(listTovars d)
    {
        b = d;
        InitializeComponent();
        nado.ItemsSource = b.listik;
        nado.SelectionChanged += listBox1_SelectedIndexChanged;
    }
    public Window1(listTovars d,busket v)
    {
        b = d;
        a = v;
        InitializeComponent();
        nado.ItemsSource = b.listik;
        nado.SelectionChanged += listBox1_SelectedIndexChanged;
    }
    
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (nado.SelectedItem is Tovars sel)
        {
            new Window2(b,sel).Show();
            Close();
        }
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        
        if (sender is Button button)
        {
            Tovars tovarDel = (Tovars)button.DataContext;
            if (listTovars.asdasd.listik.Count == 0)
            {
                nado.ItemsSource = null;
            }
            b.listik.Remove(tovarDel);
            nado.ItemsSource = null;
            nado.ItemsSource = b.listik;
        }
        
    }

    private void Button_Click_2(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new MainWindow().Show();
        Close();
    }
    private void Button_Click_3(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }

    private void Button_Click_4(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new Window4(a,b).Show();
        Close();
    }

    private void Button_Click_5(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if(sender is Button button)
        {
            bool asd = false;
            Tovars tovar = (Tovars)button.DataContext;
            tovarsInBusket ac = new tovarsInBusket();
            tovarsInBusket ac1 = ac.tovarInTovarInBusket(tovar,ac);
            foreach (tovarsInBusket s in a.list)
            {
                if (ac1.name == s.name)
                {
                    s.kolvo += 1;
                    foreach (Tovars t in b.listik)
                    {
                        if (tovar.name == t.name)
                        {
                            t.kolichestvo -= 1;
                        }
                    }
                    asd = true;
                    nado.ItemsSource = null;
                    nado.ItemsSource = b.listik;
                }
            }
            if (!asd)
            {
                ac.name = tovar.name;
                ac.price = tovar.price;
                ac.kolvo += 1;
                foreach (Tovars t in b.listik)
                {
                    if(tovar.name == t.name)
                    {
                        t.kolichestvo -= 1;
                    }
                }
                a.add(ac);
                nado.ItemsSource = null;
                nado.ItemsSource = b.listik;
            }
        }
    }
}
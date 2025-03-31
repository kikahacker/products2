using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    listTovars list = new listTovars();
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        string a = Name.Text;
        double b = Convert.ToDouble(Price.Text);
        string c = Discription.Text;
        int d = Convert.ToInt32(kolvo.Text);
        bool asd = true;
        if (a != null && b > 0 && d>0)
        {
            
            foreach (Tovars k in list.listik)
            {
                if (k.name == a)
                {
                    new Window3("Товар уже добавлен").ShowDialog(this);
                    InitializeComponent();
                    asd = false;
                    break;
                }
            }
            if (asd)
            {
                Tovars l = new Tovars { name = a, price = b, kolichestvo = d, discr = c };
                list.add(l);
                InitializeComponent();
            }
        }
        else if ( b < 0)
        {
            new Window3("Цена не может быть отрицательной").ShowDialog(this);
        }
        else if (d < 0)
        {
            new Window3("Количество не может быть отрицательной").ShowDialog(this);
        }
        else
        {
            new Window3("Имя не введено").ShowDialog(this);
        }
    }

    private void Button_Click1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new Window1(list).Show();
        Close();
    }
}


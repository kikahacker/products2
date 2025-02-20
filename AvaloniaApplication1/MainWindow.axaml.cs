using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        list = new ObservableCollection<listTovars>();
    }
    public class listTovars
    {
        public string name { get; set; }
        public double price { get; set; }
        public int kolichestvo { get; set; }
        public string discr { get; set; }


        public override string ToString()
        {
            return $"{name} ({kolichestvo}шт) - {price}:rub за шт Описание: {discr}"; 
        }
    }
    ObservableCollection<listTovars> list;
    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        string a = Name.Text;
        double b = Convert.ToDouble(Price.Text);
        string c = Discription.Text;
        int d = Convert.ToInt32(kolvo.Text);
        list.Add(new listTovars { name = a, price = b, kolichestvo = d, discr = c });
        InitializeComponent();
    }

    private void Button_Click1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        new Window1(list).Show();
        Close();
    }
}


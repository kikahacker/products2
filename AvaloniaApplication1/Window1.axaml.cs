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
    ObservableCollection<listTovars> b;
    
    public Window1()
    {
        InitializeComponent();
        nado.ItemsSource = null;
        nado.ItemsSource = b;
    }
    public Window1(ObservableCollection<listTovars> a)
    {
        b = a;
        InitializeComponent();
        nado.ItemsSource = a;
        nado.SelectionChanged += listBox1_SelectedIndexChanged;
    }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (nado.SelectedItem is listTovars sel)
        {
            var lox123 = new Window2(sel,b);
            lox123.Show();
            Close();
        }
        
        
    }
    
    
}
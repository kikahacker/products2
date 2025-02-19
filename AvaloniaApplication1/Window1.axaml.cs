using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using static AvaloniaApplication1.MainWindow;

namespace AvaloniaApplication1;

public partial class Window1 : Window
{
    
    public Window1()
    {
        InitializeComponent();
    }
    public Window1(ObservableCollection<listTovars> a)
    {
        InitializeComponent();
        nado.ItemsSource = a;
    }
}
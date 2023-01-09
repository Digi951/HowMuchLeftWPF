using HowMuchLeft.WPF.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HowMuchLeft.WPF;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected void ApplicationStart(object sender, StartupEventArgs e)
    {
        var mainView = new MainView();
        mainView.Show();
    }
}

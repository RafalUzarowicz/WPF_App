using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM.Models;

namespace WPF_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private VehiclesModel vehiclesModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            vehiclesModel = new VehiclesModel();

        }
    }
}
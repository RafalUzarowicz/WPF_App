using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM.Models;
using WPF_MVVM.MVVMs;

namespace WPF_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public WindowService WindowService
        {
            get;
        } = new WindowService();
        private VehiclesModel VehiclesModel {
            get;
        } = new VehiclesModel();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ViewModels.VehiclesViewModel vehiclesViewModel = new ViewModels.VehiclesViewModel(VehiclesModel);
            WindowService.Show(vehiclesViewModel);
        }
    }
}
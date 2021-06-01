using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_MVVM.MVVMs
{
    public class WindowService : IWindowService
    {
        public void Show(IViewModel viewModel)
        {
            Window w = new Window();
            w.Width = 800;
            w.Height = 600;
            w.Content = viewModel;
            viewModel.Close = w.Close;
            w.Show();
        }
        public void ShowDialog(IViewModel viewModel)
        {
            Window w = new Window();
            w.Content = viewModel;
            w.Width = 350;
            w.Height = 300;
            viewModel.Close = w.Close;
            w.ShowDialog();
        }
    }
}

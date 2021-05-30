using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPF_MVVM.Models;
using WPF_MVVM.MVVMs;

namespace WPF_MVVM.ViewModels
{
    class VehiclesViewModel : IViewModel, INotifyPropertyChanged
    {
        private VehiclesModel VehiclesModel
        {
            get;
        }
        private readonly CollectionViewSource collectionViewSource;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICollectionView Vehicles
        {
            get;
        }

        private Vehicle selectedVehicle;
        public Vehicle SelectedVehicle
        {
            get
            {
                return selectedVehicle;
            }
            set
            {
                selectedVehicle = value;
                EditCommand.NotifyCanExecuteChanged();
                DeleteCommand.NotifyCanExecuteChanged();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedVehicle)));
            }
        }

        private long filterNumber = 0;
        public long FilterNumber
        {
            get
            {
                return filterNumber;
            }
            set
            {
                filterNumber = value;
                UpdateView();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FilterNumber)));
            }
        }

        public enum FilterOptions
        {
            GreaterOrEqual = 0,
            Less = 1,
            NoFilter = 2
        }

        private FilterOptions filterOption;
        public int FilterOption
        {
            get
            {
                return (int)filterOption;
            }
            set
            {
                filterOption = (FilterOptions)value;
                UpdateView();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FilterOption)));
            }
        }

        private void UpdateView()
        {
            collectionViewSource.View.Refresh();
        }

        bool FilterVehicle(Vehicle vehicle)
        {
            switch (filterOption)
            {
                case FilterOptions.GreaterOrEqual:
                    return vehicle.MaxSpeed >= filterNumber;
                case FilterOptions.Less:
                    return vehicle.MaxSpeed < filterNumber;
                default:
                case FilterOptions.NoFilter:
                    break;
            }
            return true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public Action Close
        {
            get;
            set;
        }
        private RelayCommand<object> addCommand;
        public RelayCommand<object> AddCommand => (addCommand = addCommand ?? new RelayCommand<object>(o => AddVehicle()));
        private RelayCommand<object> editCommand;
        public RelayCommand<object> EditCommand => (editCommand = editCommand ?? new RelayCommand<object>(o => EditVehicle(SelectedVehicle), o => SelectedVehicle != null));
        private RelayCommand<object> deleteCommand;
        public RelayCommand<object> DeleteCommand => (deleteCommand = deleteCommand ?? new RelayCommand<object>(o => DeleteVehicle(SelectedVehicle), o => SelectedVehicle != null));

        private RelayCommand<object> newWindowCommand;
        public RelayCommand<object> NewWindowCommand => (newWindowCommand = newWindowCommand ?? new RelayCommand<object>(o => NewWindow()));

        public VehiclesViewModel(VehiclesModel vehiclesModel)
        {
            VehiclesModel = vehiclesModel;
            collectionViewSource = new CollectionViewSource
            {
                Source = VehiclesModel.Vehicles
            };
            collectionViewSource.View.CollectionChanged += UpdateStatus;
            collectionViewSource.View.Filter = (o) => FilterVehicle((Vehicle)o);
            FilterOption = (int)FilterOptions.NoFilter;
            Vehicles = collectionViewSource.View;
        }

        public void UpdateStatus(object sender, NotifyCollectionChangedEventArgs e)
        {
            ViewItemsNumber = collectionViewSource.View.Cast<object>().Count();
        }

        private int viewItemsNumber;
        public int ViewItemsNumber
        {
            get
            {
                return viewItemsNumber;
            }
            set
            {
                viewItemsNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ViewItemsNumber)));
            }
        }

        public void NewWindow()
        {
            VehiclesViewModel vehiclesViewModel = new VehiclesViewModel(VehiclesModel);
            ((App)Application.Current).WindowService.Show(vehiclesViewModel);
        }

        public void AddVehicle()
        {
            VehicleViewModel vehiclesViewModel = new VehicleViewModel(VehiclesModel, null);
            ((App)Application.Current).WindowService.ShowDialog(vehiclesViewModel);
        }

        public void EditVehicle(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                VehicleViewModel vehicleViewModel = new VehicleViewModel(VehiclesModel, vehicle);
                ((App)Application.Current).WindowService.ShowDialog(vehicleViewModel);
            }
        }
        public void DeleteVehicle(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                VehiclesModel.Vehicles.Remove(vehicle);
            }
        }
    }
}

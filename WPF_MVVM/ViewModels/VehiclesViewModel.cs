using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                UpdateFilter();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FilterNumber)));
            }
        }

        private void UpdateFilter()
        {
            collectionViewSource.View.Refresh();
        }

        bool FilterVehicle(Vehicle vehicle)
        {
            return vehicle.MaxSpeed >= filterNumber;
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
            collectionViewSource.View.Filter = (o) => FilterVehicle((Vehicle)o);
            Vehicles = collectionViewSource.View;
        }

        public void NewWindow()
        {
            VehiclesViewModel vehiclesViewModel = new VehiclesViewModel(VehiclesModel);
            ((App)Application.Current).WindowService.Show(vehiclesViewModel);
        }

        public void AddVehicle()
        {
            VehicleViewModel studentViewModel = new VehicleViewModel(VehiclesModel, null);
            ((App)Application.Current).WindowService.ShowDialog(studentViewModel);
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
                VehiclesModel.Vehicles.Remove(vehicle);
        }
    }
}

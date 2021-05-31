using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM.Models;
using WPF_MVVM.MVVMs;

namespace WPF_MVVM.ViewModels
{
    class VehicleViewModel : IViewModel
    {
        private VehiclesModel VehiclesModel
        {
            get;
        }

        private Vehicle Vehicle
        {
            get;
        }

        public Action Close
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }
        public long MaxSpeed
        {
            get;
            set;
        }
        public DateTime ProductionDate
        {
            get;
            set;
        }
        public VehicleType VehicleType
        {
            get;
            set;
        }

        public RelayCommand<VehicleViewModel> OkCommand { get; } = new RelayCommand<VehicleViewModel>
            (
                (studentViewModel) => { studentViewModel.Ok(); }
            );
        public RelayCommand<VehicleViewModel> CancelCommand { get; } = new RelayCommand<VehicleViewModel>
            (
                (studentViewModel) => { studentViewModel.Cancel(); }
            );

        public VehicleViewModel(VehiclesModel vehiclesModel, Vehicle vehicle)
        {
            VehiclesModel = vehiclesModel;
            Vehicle = vehicle;
            if(vehicle != null)
            {
                Brand = Vehicle.Brand;
                MaxSpeed = Vehicle.MaxSpeed;
                ProductionDate = Vehicle.ProductionDate;
                VehicleType = Vehicle.VehicleType;
            }
            else
            {
                Brand = "Audi";
                MaxSpeed = 100;
                ProductionDate = new DateTime();
                VehicleType = VehicleType.Car;
            }
        }

        public void Ok()
        {

            if (Vehicle == null)
            {
                Vehicle vehicle = new Vehicle(Brand, MaxSpeed, ProductionDate, VehicleType);
                VehiclesModel.Vehicles.Add(vehicle);
            }
            else
            {
                Vehicle.Brand = Brand;
                Vehicle.MaxSpeed = MaxSpeed;
                Vehicle.ProductionDate = ProductionDate;
                Vehicle.VehicleType = VehicleType;
            }
            Close?.Invoke();
        }

        public void Cancel()
        {
            Close?.Invoke();
        }
    }
}

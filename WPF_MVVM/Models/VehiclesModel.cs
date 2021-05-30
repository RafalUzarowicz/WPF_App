using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.Models
{
    class VehiclesModel
    {
        private ObservableCollection<Vehicle> vehicles;
        public ObservableCollection<Vehicle> Vehicles
        {
            get
            {
                return vehicles;
            }
        }

        public VehiclesModel()
        {
            vehicles = new ObservableCollection<Vehicle>();
            Vehicles.Add(new Vehicle("Audi", 129, new DateTime(), VehicleType.Car));
            Vehicles.Add(new Vehicle("BMW", 190, new DateTime(), VehicleType.Bike));
            Vehicles.Add(new Vehicle("Toyota", 258, new DateTime(), VehicleType.Truck));
        }
    }
}

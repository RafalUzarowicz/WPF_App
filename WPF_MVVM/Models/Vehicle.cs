using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPF_MVVM.Models
{
    public enum VehicleType
    {
        Car=0,
        Truck=1,
        Bike=2
    }

    public static class VehicleTypeExtension
    {
        private static ImageSource CAR_IMAGE_SOURCE = new BitmapImage(new Uri("/UserControls/car.png", UriKind.Relative));
        private static ImageSource TRUCK_IMAGE_SOURCE = new BitmapImage(new Uri("/UserControls/truck.png", UriKind.Relative));
        private static ImageSource BIKE_IMAGE_SOURCE = new BitmapImage(new Uri("/UserControls/bike.png", UriKind.Relative));

        public static ImageSource GetVehicleTypeImageSource(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Bike:
                    return BIKE_IMAGE_SOURCE;
                case VehicleType.Truck:
                    return TRUCK_IMAGE_SOURCE;
                case VehicleType.Car:
                default:
                    return CAR_IMAGE_SOURCE;
            }
        }
    }
    class Vehicle : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string brand;
        public string Brand
        {
            get{ 
                return brand; 
            }
            set
            {
                brand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Brand"));
            }
        }

        private long maxSpeed;
        public long MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaxSpeed"));
            }
        }

        private DateTime productionDate;
        public DateTime ProductionDate
        {
            get
            {
                return productionDate;
            }
            set
            {
                productionDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProductionDate"));
            }
        }

        private VehicleType vehicleType;
        public VehicleType VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VehicleType"));
            }
        }

        public Vehicle(string brand, long maxSpeed, DateTime productionDate, VehicleType vehicleType)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionDate = productionDate;
            VehicleType = vehicleType;
        }
    }
}

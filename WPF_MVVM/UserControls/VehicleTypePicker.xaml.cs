using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MVVM.Models;

namespace WPF_MVVM.UserControls
{
    /// <summary>
    /// Interaction logic for VehicleTypePicker.xaml
    /// </summary>
    public partial class VehicleTypePicker : UserControl
    {
        public VehicleTypePicker()
        {
            InitializeComponent();
            VehicleType = VehicleType.Car;
            UpdateLayout();
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
            }
        }

        private void UpdateLayout()
        {
            VehicleTypeImage.Source = VehicleTypeExtension.GetVehicleTypeImageSource(VehicleType);
            CurrentTypeLabel.Content = VehicleType.ToString();
        }

        private void ChangeType_ButtonClick(object sender, RoutedEventArgs e)
        {
            PickNextVehicleType();
            UpdateLayout();
        }

        private void PickNextVehicleType()
        {
            switch (VehicleType)
            {
                case VehicleType.Car:
                    VehicleType = VehicleType.Truck;
                    break;
                case VehicleType.Truck:
                    VehicleType = VehicleType.Bike;
                    break;
                case VehicleType.Bike:
                default:
                    VehicleType = VehicleType.Car;
                    break;
            }
        }
    }
}

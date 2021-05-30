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
        public static readonly DependencyProperty VehicleTypeProperty =
            DependencyProperty.Register("VehicleType", typeof(VehicleType), typeof(VehicleTypePicker),
                new PropertyMetadata(VehicleType.Car, OnVehicleTypeChange));

        public VehicleTypePicker()
        {
            InitializeComponent();
            VehicleType = VehicleType.Car;
            UpdateControl();
        }

        public VehicleType VehicleType
        {
            get
            {
                return (VehicleType)GetValue(VehicleTypeProperty);
            }
            set
            {
                SetValue(VehicleTypeProperty, value);
            }
        }

        private static void OnVehicleTypeChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is VehicleTypePicker vehicleTypePicker)
            {
                vehicleTypePicker.UpdateControl();
            }
        }

        private void UpdateControl()
        {
            VehicleTypeImg.Source = VehicleTypeExtension.GetVehicleTypeImageSource(VehicleType);
        }

        private void ChangeType_ButtonClick(object sender, RoutedEventArgs e)
        {
            PickNextVehicleType();
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
            UpdateControl();
        }
    }
}

using SKUWPFAppHVAC.ViewModel;
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

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for WaterFlowPipe.xaml
    /// </summary>
    public partial class WaterFlowPipe : UserControl
    {
        AccessData _dataContext;

        public WaterFlowPipe()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;
        }

        private void PipeDiameterManualInputCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PipeDiameter_Combobox.Visibility = Visibility.Collapsed;
            PipeDiameterTextBox.Visibility = Visibility.Visible;
        }

        private void PipeDiameterManualInputCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PipeDiameter_Combobox.Visibility = Visibility.Visible;
            PipeDiameterTextBox.Visibility = Visibility.Collapsed;
        }

        private void FlowMeters3PerHourRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FlowM3HTextBox.IsEnabled = true;
            FlowKgHTextBox.IsEnabled = false;
            FlowLSTextBox.IsEnabled = false;
        }


        private void FlowKilogramsPerHourRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FlowKgHTextBox.IsEnabled = true;
            FlowM3HTextBox.IsEnabled = false;
            FlowLSTextBox.IsEnabled = false;
        }

        private void FlowLitersPerSecondRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            FlowLSTextBox.IsEnabled = true;
            FlowM3HTextBox.IsEnabled = false;
            FlowKgHTextBox.IsEnabled = false;
        }

        private void PipePowerInputCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PowerTextBox.IsEnabled = true;
            TSupplyTextBox.IsEnabled = true;
            TReturnTextBox.IsEnabled = true;
            FlowMeters3PerHourRadioButton.IsEnabled= false;
            FlowKilogramsPerHourSecondRadioButton.IsEnabled = false;
            FlowLitersPerSecondRadioButton.IsEnabled = false;
        }

        private void PipePowerInputCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PowerTextBox.IsEnabled = false;
            TSupplyTextBox.IsEnabled = false;
            TReturnTextBox.IsEnabled = false;
            FlowMeters3PerHourRadioButton.IsEnabled = true;
            FlowKilogramsPerHourSecondRadioButton.IsEnabled = true;
            FlowLitersPerSecondRadioButton.IsEnabled = true;
        }
    }
}

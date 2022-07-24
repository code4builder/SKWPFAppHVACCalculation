using SKUWPFAppHVAC.Data;
using System.Windows;
using System.Windows.Controls;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for AirCircularDucts.xaml
    /// </summary>
    public partial class AirCircularDucts : UserControl
    {
        AccessData _dataContext;
        public AirCircularDucts()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;
        }


        private void RadioButtonLitersPerSecond_Checked(object sender, RoutedEventArgs e)
        {
            boxCircDuctAirFlowLS_Combo.IsEnabled = true;
            boxCircDuctAirFlow_Combo.IsEnabled = false;
        }

        private void RadioButtonLitersPerSecond_Unchecked(object sender, RoutedEventArgs e)
        {
            boxCircDuctAirFlowLS_Combo.IsEnabled = false;
            boxCircDuctAirFlow_Combo.IsEnabled = true;
        }

        private void CircDuctsManualInputCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CircDuctDiameter_Combobox.Visibility = Visibility.Collapsed;
            CircDuctDiameterTextBox.Visibility = Visibility.Visible;
        }

        private void CircDuctsManualInputCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CircDuctDiameter_Combobox.Visibility = Visibility.Visible;
            CircDuctDiameterTextBox.Visibility = Visibility.Collapsed;
        }
    }
}

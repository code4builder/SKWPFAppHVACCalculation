using SKUWPFAppHVAC.Data;
using System.Windows;
using System.Windows.Controls;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for Air.xaml
    /// </summary>
    public partial class AirRectangularDucts : UserControl
    {
        AccessData _dataContext;

        public AirRectangularDucts()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;

        }

        private void RadioButtonRectLitersPerSecond_Checked(object sender, RoutedEventArgs e)
        {
            boxRectDuctAirFlowLS_Combo.IsEnabled = true;
            boxRectDuctAirFlow_Combo.IsEnabled = false;
        }

        private void RadioButtonRectLitersPerSecond_Unchecked(object sender, RoutedEventArgs e)
        {
            boxRectDuctAirFlowLS_Combo.IsEnabled = false;
            boxRectDuctAirFlow_Combo.IsEnabled = true;
        }

        private void RectDuctsManualInputCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            RectDuctWidth_Combobox.Visibility = Visibility.Collapsed;
            RectDuctHeight_Combobox.Visibility = Visibility.Collapsed;
            BoxRectDuctWidth.Visibility = Visibility.Visible;
            BoxRectDuctHeight.Visibility = Visibility.Visible;
        }

        private void RectDuctsManualInputCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            RectDuctWidth_Combobox.Visibility = Visibility.Visible;
            RectDuctHeight_Combobox.Visibility = Visibility.Visible;
            BoxRectDuctWidth.Visibility = Visibility.Collapsed;
            BoxRectDuctHeight.Visibility = Visibility.Collapsed;
        }
    }
}

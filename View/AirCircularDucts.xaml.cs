using SKUWPFAppHVAC.Data;
using SKUWPFAppHVAC.Data.Calculations;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for AirCircularDucts.xaml
    /// </summary>
    public partial class AirCircularDucts : Page
    {
        AccessData _dataContext;
        public AirCircularDucts()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;
        }
        
        int _selectedCircDuctDiameter;
        int _selectedCircDuctAirflow;
        double _selectedCircDuctAirflowLS;

        private void ShowResult()
        {
            double airflowLS = CalculationDucts.CalculateDuctAirflowLS(_dataContext.SelectedAirflow);

            double velocity = CalculationDucts.CalculateCircDuctVelocity(
                _dataContext.SelectedCircDuctSize.CircDuctSingleSize,                
                _dataContext.SelectedAirflow);

            boxCircDuctAirFlowLS_Combo.Text = airflowLS.ToString();
            boxCircDuctVelocity_Combo.Text = velocity.ToString();
        }

        //Combobox for Circular Ducts
        private void CircDuctDiameter_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowResult();
        }
        
        private void BoxCircDuctAirFlowCombo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RadioButtonMeters3PerHour.IsChecked == true && boxCircDuctAirFlow_Combo != null && Int32.TryParse(boxCircDuctAirFlow_Combo.Text.Trim(), out _selectedCircDuctAirflow))
            {
                boxCircDuctAirFlowLS_Combo.Text = CalculationDucts.CalculateDuctAirflowLS(_selectedCircDuctAirflow).ToString();
                boxCircDuctVelocity_Combo.Text = CalculationDucts.CalculateCircDuctVelocity(_selectedCircDuctDiameter, _selectedCircDuctAirflow).ToString();
                boxCircDuctVelocity_Combo.Background = Brushes.BlanchedAlmond;
                boxCircDuctAirFlow_Combo.SelectionStart = 20;
            }
            else
            {
                boxCircDuctVelocity_Combo.Text = "Insert only \nintegers";
                boxCircDuctVelocity_Combo.Background = Brushes.Salmon;
                boxCircDuctVelocity_Combo.TextWrapping = TextWrapping.WrapWithOverflow;
            }
        }

        private void BoxCircDuctAirFlowLS_Combo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RadioButtonLitersPerSecond.IsChecked == true && Double.TryParse(boxCircDuctAirFlowLS_Combo.Text.Trim(), out _selectedCircDuctAirflowLS))
            {                
                boxCircDuctAirFlow_Combo.Text = CalculationDucts.CalculateDuctAirflow(_selectedCircDuctAirflowLS).ToString();
                _selectedCircDuctAirflow = CalculationDucts.CalculateDuctAirflow(_selectedCircDuctAirflowLS);
                boxCircDuctVelocity_Combo.Text = CalculationDucts.CalculateCircDuctVelocity(_selectedCircDuctDiameter, _selectedCircDuctAirflow).ToString();
                boxCircDuctVelocity_Combo.Background = Brushes.BlanchedAlmond;
            }
            else
            {
                boxCircDuctVelocity_Combo.Text = "Insert only\nnumbers with \",\"";
                boxCircDuctVelocity_Combo.Width = 200;
                boxCircDuctVelocity_Combo.Background = Brushes.Salmon;
                boxCircDuctVelocity_Combo.TextWrapping = TextWrapping.WrapWithOverflow;
            }
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
    }
}

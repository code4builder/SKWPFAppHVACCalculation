using SKUWPFAppHVAC.Data;
using SKUWPFAppHVAC.Data.Calculations;
using SKUWPFAppHVAC.Data.Content.ListsData;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for Air.xaml
    /// </summary>
    public partial class AirRectangularDucts : Page
    {
        AccessData _dataContext;

        public class Converter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if ((double)value > 5)
                    return 1;
                else
                    return 0;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }

        public AirRectangularDucts()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;

        }

        //Calculations with size selection from Comboboxes for Rectangular Ducts
        //int _selectedRectDuctWidth;
        //int _selectedRectDuctHeight;
        //int _selectedRectDuctAirflow; 
        //double _selectedRectDuctAirflowLS;

        //private void ShowResult()
        //{
        //    double airflowLS = CalculationDucts.CalculateDuctAirflowLS(_dataContext.SelectedAirflow);

        //    double velocity = CalculationDucts.CalculateRectDuctVelocity(
        //        _dataContext.SelectedRectDuctWidth.RectDuctSingleSize, 
        //        _dataContext.SelectedRectDuctHeight.RectDuctSingleSize,
        //        _dataContext.SelectedAirflow);

        //    boxRectDuctAirFlowLS_Combo.Text = airflowLS.ToString();
        //    boxRectVelocity_Combo.Text = velocity.ToString();
        //}

        #region RECT DUCTS CALCULATION WITH COMBOBOXES

        //private void RectDuct_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ShowResult();
        //}

        //private void BoxRectDuctAirFlowCombo_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    //TextBox textBox = sender as TextBox;


        //    //if (RadioButtonRectMeters3PerHourCombo.IsChecked == true && Int32.TryParse(boxRectDuctAirFlow_Combo.Text, out _selectedRectDuctAirflow))
        //    //{
        //    //    _dataContext.SelectedAirflow = _selectedRectDuctAirflow;
        //    //    ShowResult();

        //    //    //boxRectDuctAirFlow_Combo.SelectionStart = 20;
        //    //}
        //    //else
        //    //{
        //    //    boxRectVelocity_Combo.Text = "Insert only \nintegers";

        //    //    boxRectVelocity_Combo.TextWrapping = TextWrapping.WrapWithOverflow;                
        //    //}
        //}

        //private void BoxRectDuctAirFlowLS_Combo_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (RadioButtonRectLitersPerSecondCombo.IsChecked == true && Double.TryParse(boxRectDuctAirFlowLS_Combo.Text, out _selectedRectDuctAirflowLS))
        //    {
        //        boxRectDuctAirFlow_Combo.Text = CalculationDucts.CalculateDuctAirflow(_selectedRectDuctAirflowLS).ToString();
        //        _selectedRectDuctAirflow = CalculationDucts.CalculateDuctAirflow(_selectedRectDuctAirflowLS);
        //        boxRectVelocity_Combo.Text = CalculationDucts.CalculateRectDuctVelocity(_selectedRectDuctWidth, _selectedRectDuctHeight, _selectedRectDuctAirflow).ToString();

        //    }
        //    else
        //    {
        //        boxRectVelocity_Combo.Text = "Only numbers";

        //    }
        //}

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

        #endregion

        #region RECT DUCTS CALCULATION WITH TEXTBOXES

        //Calculations with manual input of size for Rectangular Ducts
        //int rectDuctWidthManual, rectDuctHeightManual, rectDuctAirFlowManual;
        //double rectDuctAirFlowLSManual;

        //private void BoxRectDuctWidth_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (boxRectDuctWidth != null && boxRectDuctHeight != null && boxRectDuctAirFlow != null && boxRectDuctAirFlowLS != null && Int32.TryParse(boxRectDuctWidth.Text, out rectDuctWidthManual))
        //    {                    
        //        boxRectDuctAirFlowLS.Text = CalculationDucts.CalculateDuctAirflowLS(rectDuctAirFlowManual).ToString();
        //        boxRectVelocity.Text = CalculationDucts.CalculateRectDuctVelocity(rectDuctWidthManual, rectDuctHeightManual, rectDuctAirFlowManual).ToString();
        //        boxRectVelocity.Background = Brushes.BlanchedAlmond;

        //    }
        //    else
        //    {
        //        boxRectVelocity.Text = "Insert only \nintegers";                
        //        boxRectVelocity.TextWrapping = TextWrapping.WrapWithOverflow;
        //    }
        //}
        //private void BoxRectDuctHeight_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (boxRectDuctWidth != null && boxRectDuctHeight != null && boxRectDuctAirFlow != null && boxRectDuctAirFlowLS != null && Int32.TryParse(boxRectDuctHeight.Text, out rectDuctHeightManual))
        //    {
        //        boxRectDuctAirFlowLS.Text = CalculationDucts.CalculateDuctAirflowLS(rectDuctAirFlowManual).ToString();
        //        boxRectVelocity.Text = CalculationDucts.CalculateRectDuctVelocity(rectDuctWidthManual, rectDuctHeightManual, rectDuctAirFlowManual).ToString();

        //        boxRectVelocity.SelectionStart = 20;
        //    }
        //    else
        //    {
        //        boxRectVelocity.Text = "Insert only \nintegers";                
        //        boxRectVelocity.TextWrapping = TextWrapping.WrapWithOverflow;
        //    }
        //}
        //private void BoxRectDuctAirFlow_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (boxRectDuctWidth != null && boxRectDuctHeight != null && Int32.TryParse(boxRectDuctAirFlow.Text, out rectDuctAirFlowManual) && RadioButtonRectMeters3PerHourManual.IsChecked == true)
        //    {                
        //        boxRectDuctAirFlowLS.Text = CalculationDucts.CalculateDuctAirflowLS(rectDuctAirFlowManual).ToString();
        //        boxRectVelocity.Text = CalculationDucts.CalculateRectDuctVelocity(rectDuctWidthManual, rectDuctHeightManual, rectDuctAirFlowManual).ToString();                

        //        boxRectVelocity.SelectionStart = 20;
        //    }
        //    else
        //    {
        //        boxRectVelocity.Text = "Insert only \nintegers";

        //        boxRectVelocity.TextWrapping = TextWrapping.WrapWithOverflow;
        //    }
        //}
        //private void BoxRectDuctAirFlowLS_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (boxRectDuctWidth != null && boxRectDuctHeight != null && Double.TryParse(boxRectDuctAirFlowLS.Text, out rectDuctAirFlowLSManual) && RadioButtonRectMeters3PerHourManual.IsChecked == false)
        //    {
        //        boxRectDuctAirFlow.Text = CalculationDucts.CalculateDuctAirflow(rectDuctAirFlowLSManual).ToString();
        //        boxRectVelocity.Text = CalculationDucts.CalculateRectDuctVelocity(rectDuctWidthManual, rectDuctHeightManual, rectDuctAirFlowManual).ToString();

        //        boxRectVelocity.SelectionStart = 20;
        //    }
        //    else
        //    {
        //        boxRectVelocity.Text = "Only numbers";

        //        boxRectVelocity.TextWrapping = TextWrapping.WrapWithOverflow;
        //    }
        //}



        #endregion


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

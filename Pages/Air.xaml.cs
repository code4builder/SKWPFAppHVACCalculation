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
using SKUWPFAppHVAC.Data;
using SKUWPFAppHVAC.Data.Content.ListsData;
using SKUWPFAppHVAC.Data.Calculations;

namespace SKUWPFAppHVAC.Pages
{
    /// <summary>
    /// Interaction logic for Air.xaml
    /// </summary>
    public partial class Air : Page
    {
        public Air()
        {
            InitializeComponent();

            DataContext = new AccessData();

        }

        int selectedRectDuctWidth = 100;
        int selectedRectDuctHeight = 100;
        double selectedRectDuctAirflow = 0;
        double selectedRectDuctAirflowLS = 0;

        int rectDuctWidth, rectDuctHeight, rectDuctAirFlow;
        double rectDuctVelocity, rectDuctAirFlowLS;

        //TODO: Add a new class for this calculation
        void CalculateRectDuctVelocity()
        {
            double equivalentDiameterRectDuct = 1.3 * (Math.Pow((rectDuctWidth * rectDuctHeight), 0.625) / Math.Pow((rectDuctWidth + rectDuctHeight), 0.25));
            double sectionAreaEquivDiam = 3.14 * Math.Pow((equivalentDiameterRectDuct / 1000), 2) / 4;
            rectDuctVelocity = Math.Round((rectDuctAirFlow / (sectionAreaEquivDiam * 3600)), 2);
            rectDuctAirFlowLS = Math.Round((rectDuctAirFlow / 3.6), 2);

            boxRectDuctAirFlowLS.Text = rectDuctAirFlowLS.ToString();
            boxRectVelocity.Text = rectDuctVelocity.ToString();
        }

        //Combobox for Rectangular Ducts
        private void RectDuctWidth_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndexWidthCombobox = RectDuctWidth_Combobox.SelectedIndex;
            AccessData accessData = new AccessData();
            selectedRectDuctWidth = accessData.RectDuctsSizesList.ElementAt(selectedIndexWidthCombobox).RectDuctSingleSize;

            CalculationRectDuctAirflowLiterPerSecond CalculationRectRuctAirflowLSCombobox = new CalculationRectDuctAirflowLiterPerSecond();
            selectedRectDuctAirflowLS = CalculationRectRuctAirflowLSCombobox.CalculateRectDuctAirflowLS(selectedRectDuctAirflow);
            boxRectDuctAirFlowLS_Combo.Text = selectedRectDuctAirflowLS.ToString();

            CalculationRectDuctVelocity CalculationRectDuctVelocityCombobox = new CalculationRectDuctVelocity();
            double rectDuctVelocityCombo = CalculationRectDuctVelocityCombobox.CalculateRectDuctVelocity(selectedRectDuctWidth, selectedRectDuctHeight, selectedRectDuctAirflow);
            boxRectVelocity_Combo.Text = rectDuctVelocityCombo.ToString();
        }
        private void RectDuctHeight_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndexHeightCombobox = RectDuctHeight_Combobox.SelectedIndex;
            AccessData accessData = new AccessData();
            selectedRectDuctHeight = accessData.RectDuctsSizesList.ElementAt(selectedIndexHeightCombobox).RectDuctSingleSize;

            CalculationRectDuctAirflowLiterPerSecond CalculationRectDuctAirflowLSyCombobox = new CalculationRectDuctAirflowLiterPerSecond();
            selectedRectDuctAirflowLS = CalculationRectDuctAirflowLSyCombobox.CalculateRectDuctAirflowLS(selectedRectDuctAirflow);
            boxRectDuctAirFlowLS_Combo.Text = selectedRectDuctAirflowLS.ToString();

            CalculationRectDuctVelocity CalculationRectDuctVelocityCombobox = new CalculationRectDuctVelocity();
            double rectDuctVelocityCombo = CalculationRectDuctVelocityCombobox.CalculateRectDuctVelocity(selectedRectDuctWidth, selectedRectDuctHeight, selectedRectDuctAirflow);
            boxRectVelocity_Combo.Text = rectDuctVelocityCombo.ToString();
        }
        private void BoxRectDuctAirFlowCombo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxRectDuctAirFlow_Combo != null && boxRectVelocity_Combo != null && boxRectDuctAirFlowLS_Combo != null)
            {
                try
                {
                    selectedRectDuctAirflow = Double.Parse(boxRectDuctAirFlow_Combo.Text.Trim());
                }
                catch (Exception myException) { MessageBox.Show("You can type only integer numbers: " + myException.Message); }

                CalculationRectDuctAirflowLiterPerSecond CalculationRectDuctAirflowLSyCombobox = new CalculationRectDuctAirflowLiterPerSecond();
                selectedRectDuctAirflowLS = CalculationRectDuctAirflowLSyCombobox.CalculateRectDuctAirflowLS(selectedRectDuctAirflow);
                boxRectDuctAirFlowLS_Combo.Text = selectedRectDuctAirflowLS.ToString();

                CalculationRectDuctVelocity CalculationRectDuctVelocityCombobox = new CalculationRectDuctVelocity();
                double rectDuctVelocityCombo = CalculationRectDuctVelocityCombobox.CalculateRectDuctVelocity(selectedRectDuctWidth, selectedRectDuctHeight, selectedRectDuctAirflow);
                boxRectVelocity_Combo.Text = rectDuctVelocityCombo.ToString();
            }
        }

        private void boxRectDuctAirFlowLS_Combo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxRectDuctAirFlow_Combo != null && boxRectVelocity_Combo != null && boxRectDuctAirFlowLS_Combo != null)
            {
                try
                {
                    selectedRectDuctAirflowLS = Double.Parse(boxRectDuctAirFlowLS_Combo.Text.Trim());
                }
                catch (Exception myException) { MessageBox.Show("You can type only numbers: " + myException.Message); }

                CalculationRectDuctAirflowM3PerHour CalculationRectDuctAirflowCombobox = new CalculationRectDuctAirflowM3PerHour();
                selectedRectDuctAirflow = (Int32)CalculationRectDuctAirflowCombobox.CalculateRectDuctAirflow(selectedRectDuctAirflowLS);
                boxRectDuctAirFlow_Combo.Text = selectedRectDuctAirflow.ToString();

                CalculationRectDuctVelocity CalculationRectDuctVelocityCombobox = new CalculationRectDuctVelocity();
                double rectDuctVelocityCombo = CalculationRectDuctVelocityCombobox.CalculateRectDuctVelocity(selectedRectDuctWidth, selectedRectDuctHeight, selectedRectDuctAirflow);
                boxRectVelocity_Combo.Text = rectDuctVelocityCombo.ToString();
            }
        }






        //Manual Insert for Rectangular Ducts
        private void BoxRectDuctWidth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxRectDuctWidth != null && boxRectDuctHeight != null && boxRectDuctAirFlow != null && boxRectVelocity != null && boxRectDuctAirFlowLS != null)
            {
                try
                {
                    rectDuctWidth = Int32.Parse(boxRectDuctWidth.Text.Trim());

                }
                catch (Exception myException) { MessageBox.Show("You can type only numbers: " + myException.Message); }

                CalculateRectDuctVelocity();
            }
        }
        private void BoxRectDuctHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxRectDuctWidth != null && boxRectDuctHeight != null && boxRectDuctAirFlow != null && boxRectVelocity != null && boxRectDuctAirFlowLS != null)
            {
                try
                {
                    rectDuctHeight = Int32.Parse(boxRectDuctHeight.Text.Trim());
                }
                catch (Exception myException) { MessageBox.Show("You can type only numbers: " + myException.Message); }

                CalculateRectDuctVelocity();
            }
        }
        private void BoxRectDuctAirFlow_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxRectDuctWidth != null && boxRectDuctHeight != null && boxRectDuctAirFlow != null && boxRectVelocity != null && boxRectDuctAirFlowLS != null)
            {
                try
                {

                    rectDuctAirFlow = Int32.Parse(boxRectDuctAirFlow.Text.Trim());
                }
                catch (Exception myException) { MessageBox.Show("You can type only numbers: " + myException.Message); }

                CalculateRectDuctVelocity();
            }
        }

    }
}

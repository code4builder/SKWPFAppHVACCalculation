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

namespace SKUWPFAppHVAC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        int rectDuctWidth, rectDuctHeight, rectDuctAirFlow;
        double rectDuctVelocity, rectDuctAirFlowLS;

        void CalculateRectDuctVelocity()
        {
            double equivalentDiameterRectDuct = 1.3 * (Math.Pow((rectDuctWidth * rectDuctHeight), 0.625) / Math.Pow((rectDuctWidth + rectDuctHeight), 0.25));
            double sectionAreaEquivDiam = 3.14 * Math.Pow((equivalentDiameterRectDuct / 1000), 2) / 4;
            rectDuctVelocity = Math.Round((rectDuctAirFlow / (sectionAreaEquivDiam * 3600)), 2);
            rectDuctAirFlowLS = Math.Round((rectDuctAirFlow / 3.6),2);

            boxRectDuctAirFlowLS.Text = rectDuctAirFlowLS.ToString();
            boxRectVelocity.Text = rectDuctVelocity.ToString();
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application was created by Sergey Kulkeshov/n Email:");
        }

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
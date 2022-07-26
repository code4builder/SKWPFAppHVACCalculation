using System.Windows.Controls;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for AirPage.xaml
    /// </summary>
    public partial class AirPage : Page
    {
        public AirRectangularDucts airRectangularDucts;
        public AirCircularDucts airCircularDucts;
        public HeatingPowerForAirflow heatingPowerForAirflow;
        public AirPage()
        {
            InitializeComponent();
            airRectangularDucts = new AirRectangularDucts();
            airCircularDucts = new AirCircularDucts();
            heatingPowerForAirflow = new HeatingPowerForAirflow();
            AirPageFrame1.Content = airRectangularDucts;
            AirPageFrame2.Content = airCircularDucts;
            AirPageFrame3.Content = heatingPowerForAirflow;
        }
    }
}

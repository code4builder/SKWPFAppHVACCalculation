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
        public AirPage()
        {
            InitializeComponent();
            airRectangularDucts = new AirRectangularDucts();
            airCircularDucts = new AirCircularDucts();
            AirPageFrame1.Content = airRectangularDucts;
            AirPageFrame2.Content = airCircularDucts;

        }
    }
}

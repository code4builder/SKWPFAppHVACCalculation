using SKUWPFAppHVAC.ViewModel;
using System.Windows.Controls;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for HeatingPowerForAirflow.xaml
    /// </summary>
    public partial class HeatingPowerForAirflow : UserControl
    {
        AccessData _dataContext;
        public HeatingPowerForAirflow()
        {
            InitializeComponent();
            _dataContext = new AccessData();
            DataContext = _dataContext;
        }
    }
}

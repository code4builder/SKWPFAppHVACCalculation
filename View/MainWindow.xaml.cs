using SKUWPFAppHVAC.View;
using System.Windows;

namespace SKUWPFAppHVAC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AirRectangularDucts AirRectangularDuctsPage;
        public Water WaterPage;
        public AirCircularDucts AirCircularDuctsPage;
        public UserGuideDucts UserGuideDuctsPage;

        public MainWindow()
        {
            InitializeComponent();
            AirRectangularDuctsPage = new AirRectangularDucts();
            WaterPage = new Water();
            AirCircularDuctsPage = new AirCircularDucts();
            UserGuideDuctsPage = new UserGuideDucts();
            MainWindowFrame1.Content = AirRectangularDuctsPage;
            MainWindowFrame2.Content = AirCircularDuctsPage;
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HVAC Small Calculator \nSmall tool for basic calculations for ducts and pipes \n" +
                            "This application was created by Sergey Kuleshov \nEmail: code4builder@gmail.com");
        }

        private void AirButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = AirRectangularDuctsPage;
            MainWindowFrame2.Content = AirCircularDuctsPage;
            MainGrid.RowDefinitions[1].Height = new GridLength(250);
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = WaterPage;
            MainWindowFrame2.Content = null;
            MainGrid.RowDefinitions[1].Height = new GridLength(250);
        }

        private void MenuItemUserGuideDucts_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = UserGuideDuctsPage;
            MainGrid.RowDefinitions[1].Height = new GridLength(1000);
            MainWindowFrame2.Content = null;
        }


    }
}
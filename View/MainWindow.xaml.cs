using SKUWPFAppHVAC.View;
using System.Windows;

namespace SKUWPFAppHVAC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AirPage AirPage;
        public WaterPage WaterPage;
        public UserGuideDucts UserGuideDuctsPage;

        public MainWindow()
        {
            InitializeComponent();
            WaterPage = new WaterPage();
            AirPage = new AirPage();
            UserGuideDuctsPage = new UserGuideDucts();
            MainWindowFrame1.Content = AirPage;
            
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HVAC Small Calculator \nSmall tool for basic calculations for ducts and pipes \n" +
                            "This application was created by Sergey Kuleshov \nEmail: code4builder@gmail.com");
        }

        private void AirButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = AirPage;
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = WaterPage;
        }

        private void MenuItemUserGuideDucts_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = UserGuideDuctsPage;
        }


    }
}
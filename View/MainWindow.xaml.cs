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
        public UserGuidePipes UserGuidePipesPage;

        public MainWindow()
        {
            InitializeComponent();
            WaterPage = new WaterPage();
            AirPage = new AirPage();
            UserGuideDuctsPage = new UserGuideDucts();
            UserGuidePipesPage = new UserGuidePipes();
            MainWindowFrame1.Content = AirPage;
            
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HVAC Small Calculator V1.0.0 \n \nSmall tool for basic calculations for ducts and pipes \n \n" +
                            "This application was created by Sergey Kuleshov \n \nEmail: code4builder@gmail.com");
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

        private void MenuItemUserGuidePipes_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame1.Content = UserGuidePipesPage;
        }

        private void YouTubeGuide_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZUrc1izY6QI");
        }
    }
}
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
using SKUWPFAppHVAC.Pages;
using SKUWPFAppHVAC.Data;

namespace SKUWPFAppHVAC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Air AirPage;
        public Water WaterPage;

        public MainWindow()
        {
            InitializeComponent();
            AirPage = new Air();
            WaterPage = new Water();
            MainWindowFrame.Content = AirPage;
        }

        private void MIAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application was created by Sergey Kuleshov Email:");
        }

        private void AirButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = AirPage;
        }

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = WaterPage;
        }

        

    }
}
using System.Windows;

namespace AsianCuisine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        bool chinaIsClicked;
        bool japanIsClicked;
        bool southKoreaIsClicked;
        private void China_Click(object sender, RoutedEventArgs e)
        {
            chinaIsClicked = true;
            japanIsClicked = false;
            southKoreaIsClicked = false;
        }

        private void Japan_Click(object sender, RoutedEventArgs e)
        {
            japanIsClicked = true;
            chinaIsClicked = false;
            southKoreaIsClicked = false;
        }

        private void SouthKorea_Click(object sender, RoutedEventArgs e)
        {
            southKoreaIsClicked = true;
            chinaIsClicked = false;
            japanIsClicked = false;
        }
    }
}

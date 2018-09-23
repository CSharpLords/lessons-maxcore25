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

namespace HellClicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstPlayerClick(object sender, MouseButtonEventArgs e)
        {
            ProgressBar.Value--;
            if (ProgressBar.Value == 0)
            {
                VictoryLabel.Content = "player two win";
                Win.KeyDown -= SecondPlayerClick;
            }
        }

        private void SecondPlayerClick(object sender, KeyEventArgs e)
        {
            ProgressBar.Value++;
            if (ProgressBar.Value == 100)
            {
                VictoryLabel.Content = "player one win";

            }
        }
    }
}

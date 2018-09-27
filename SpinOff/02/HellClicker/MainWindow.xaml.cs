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

        private void FirstPlayerClick(object sender, KeyEventArgs e)
        {
            ProgressBar.Value++;
            if (ProgressBar.Value == 100)
            {
                VictoryLabel.Content = "player 1 won";
                Win.MouseLeftButtonDown-= SecondPlayerClick;
            }
        }
        
        private void SecondPlayerClick(object sender, MouseButtonEventArgs e)
        {
            ProgressBar.Value--;
            if (ProgressBar.Value == 0)
            {
                VictoryLabel.Content = "player 2 won";
                Win.KeyDown -= FirstPlayerClick;
            }
        }

        
    }
}

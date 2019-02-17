using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using AsianCuisine.Model;
using BLToolkit.Data;

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
            List<Country> countries = GetCountries();
            foreach (Country country in countries)
            {
                IconButton button = new IconButton();
                button.Icon = country.Flag;
                button.Label = country.Name;
                button.ID = country.ID;
                Countries.Items.Add(button);
            }
        }

        private List<Country> GetCountries()
        {
            using (DbManager db = new DbManager())
            {
                db.SetSpCommand("GetCountries");
                List<Country> countries = db.ExecuteList<Country>();
                return countries;
            }
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

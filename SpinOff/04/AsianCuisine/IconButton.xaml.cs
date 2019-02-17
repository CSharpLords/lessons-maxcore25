using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using AsianCuisine.Model;

namespace AsianCuisine
{
    /// <summary>
    /// Логика взаимодействия для IconButton.xaml
    /// </summary>
    public partial class IconButton : Button
    {
        public static DependencyProperty IconProperty =
            DependencyProperty.Register(
                "Icon", typeof(string), typeof(IconButton)
            );
        
        [Category("Common")]
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static DependencyProperty LabelProperty =
            DependencyProperty.Register(
                "Label", typeof(string), typeof(IconButton)
            );

        [Category("Common")]
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public Guid ID { get; set; }

        public IconButton()
        {
            InitializeComponent();
        }

        private void iconButton_Click(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("DishTypes.xaml", UriKind.RelativeOrAbsolute), ID);
        }
    }
}

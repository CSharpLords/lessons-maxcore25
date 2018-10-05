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

namespace Paint2018
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point currentPoint;
        Point eraserCurrentPoint;
        static bool switchOnEraser = false;
        static byte clicksAmount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && switchOnEraser == false)
            {
                Mouse.OverrideCursor = Cursors.Pen;
                Line line = new Line();
                line.Stroke = new SolidColorBrush(ColorPicker.SelectedColor ?? Brushes.Black.Color);
                line.StrokeThickness = 1;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(Canvas).X;
                line.Y2 = e.GetPosition(Canvas).Y;

                currentPoint = e.GetPosition(Canvas);

                Canvas.Children.Add(line);
            }
            if (switchOnEraser == true && e.LeftButton == MouseButtonState.Pressed)
            {
                Mouse.OverrideCursor = Cursors.Cross;
                Line line = new Line();
                line.Stroke = new SolidColorBrush(Brushes.LightGray.Color);
                line.StrokeThickness = 5;
                line.X1 = eraserCurrentPoint.X;
                line.Y1 = eraserCurrentPoint.Y;
                line.X2 = e.GetPosition(Canvas).X;
                line.Y2 = e.GetPosition(Canvas).Y;

                eraserCurrentPoint = e.GetPosition(Canvas);

                Canvas.Children.Add(line);
            }
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (switchOnEraser == true)
            {
                eraserCurrentPoint = e.GetPosition(Canvas);
            }
            else
            {
                currentPoint = e.GetPosition(Canvas);
            }
        }

        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            clicksAmount++;
            if (clicksAmount == 2)
            {
                switchOnEraser = false;
                clicksAmount = 0;
                Eraser.Content = "Eraser";
                Mouse.OverrideCursor = Cursors.Pen;
            }
            else
            {
                switchOnEraser = true;
                Eraser.Content = "Brush";
                Mouse.OverrideCursor = Cursors.Cross;
            }

        }

        private void BrushSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }
    }
}

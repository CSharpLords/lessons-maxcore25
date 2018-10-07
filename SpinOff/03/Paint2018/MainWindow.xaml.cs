using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Paint2018
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point currentPoint;
        bool switchOnEraser = false;
        Ellipse circle = new Ellipse();
        public MainWindow()
        {
            InitializeComponent();
            circle.StrokeThickness = 2;
            circle.Stroke = Brushes.Black;
            Canvas.Children.Add(circle);
            Panel.SetZIndex(circle, 100);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.None;
            circle.Visibility = Visibility.Visible;
            
            Line line = new Line();
            if (e.LeftButton == MouseButtonState.Pressed && switchOnEraser == false)
            {
                line.Stroke = new SolidColorBrush(ColorPicker.SelectedColor ?? Brushes.Black.Color);
            }

            if (switchOnEraser == true && e.LeftButton == MouseButtonState.Pressed)
            {
                line.Stroke = new SolidColorBrush(Brushes.LightGray.Color);
            }

            line.StrokeThickness = BrushSize.Value;
            line.StrokeEndLineCap = PenLineCap.Round;
            line.X1 = currentPoint.X;
            line.Y1 = currentPoint.Y;
            line.X2 = e.GetPosition(Canvas).X;
            line.Y2 = e.GetPosition(Canvas).Y;

            currentPoint = e.GetPosition(Canvas);
            circle.Width = BrushSize.Value;
            circle.Height = BrushSize.Value;
            if (BrushSize.Value < 6)
            {
                circle.Width = 6;
                circle.Height = 6;
            }
            Canvas.SetLeft(circle, currentPoint.X);
            Canvas.SetTop(circle, currentPoint.Y);

            Canvas.Children.Add(line);
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            currentPoint = e.GetPosition(Canvas);
        }

        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            if (switchOnEraser == true)
            {
                switchOnEraser = false;
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

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
            circle.Visibility = Visibility.Hidden;
        }

        public void ExportToPng(string path, Canvas surface)
        {
            if (path == null) 
            {
                return;
            }

            Size size = new Size(surface.Width, surface.Height);
            surface.Measure(size);
            surface.Arrange(new Rect(size));

            RenderTargetBitmap bitmap = new RenderTargetBitmap(
                (int)size.Width, (int)size.Height, 96d, 96d, PixelFormats.Pbgra32
            );
            bitmap.Render(surface);
            using (FileStream outStream = new FileStream(path, FileMode.Create))
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.Save(outStream);
            }
            
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "picture (*.png)|*.png";
            if (saveDialog.ShowDialog() == true)
            {
                ExportToPng(saveDialog.FileName, Canvas);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

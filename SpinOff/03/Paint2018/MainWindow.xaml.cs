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
        Ellipse circle = new Ellipse();
        Rectangle rectangle = new Rectangle();
        private Shape tool;

        public MainWindow()
        {
            InitializeComponent();

            circle.StrokeThickness = 2;
            circle.Stroke = Brushes.Black;
            Canvas.Children.Add(circle);
            Panel.SetZIndex(circle, 100);

            rectangle.StrokeThickness = 2;
            rectangle.Stroke = Brushes.Black;
            Canvas.Children.Add(rectangle);
            Panel.SetZIndex(rectangle, 100);

            tool = circle;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.None;
            tool.Visibility = Visibility.Visible;
            tool.Width = BrushSize.Value;
            tool.Height = BrushSize.Value;

            if (BrushSize.Value < 6)
            {
                tool.Width = 6;
                tool.Height = 6;
            }


            var toolLocation = e.GetPosition(Canvas);
            Canvas.SetLeft(tool, toolLocation.X);
            Canvas.SetTop(tool, toolLocation.Y);

            if (e.LeftButton != MouseButtonState.Pressed)
            {
                return;
            }

            Line line = new Line();
            if (tool == circle)
            {
                line.Stroke = new SolidColorBrush(ColorPicker.SelectedColor ?? Brushes.Black.Color);
            }
            else
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

            Canvas.Children.Add(line);
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            currentPoint = e.GetPosition(Canvas);
        }

        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            if (tool == circle)
            {
                Eraser.Content = "Eraser";
                tool = rectangle;
            }
            else
            {
                Eraser.Content = "Brush";
                tool = circle;
            }

        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
            tool.Visibility = Visibility.Hidden;
        }

        public void ExportToPng(string path, Canvas surface)
        {
            if (path == null)
            {
                return;
            }

            Size size = new Size(surface.Width, surface.Height);
            surface.Measure(size);
            surface.Arrange(new Rect(0, -surface.Margin.Top, size.Width, size.Height));

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
            SaveFileOperation();
        }

        private void SaveFileOperation()
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
            if (Canvas.Children.Count > 2)
            {
                if (MessageBox.Show("Do you want to save picture", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    SaveFileOperation();
                }  
            }
            Application.Current.Shutdown(); 
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImportToCanvas(openFileDialog.FileName);
            }
        }

        public void ImportToCanvas(string filePath)
        {
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(filePath));
            Canvas.Background = brush;
        }
    }
}

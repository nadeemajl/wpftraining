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

namespace InBuiltRoutedEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChangeToCapital(object sender, RoutedEventArgs routedEventArgs)
        {
            var source = routedEventArgs.Source as TextBox;

            if (source != default(TextBox))
            {
                source.Text = source.Text.ToUpper();
                source.Select(source.Text.Length, 0);
            }
        }

        private void HandleTextChangedAtGrid(object sender, TextChangedEventArgs e)
        {
            var source = e.OriginalSource as TextBox;

            if (source != default(TextBox))
            {
                var color = GenerateColor(100, 255);

                source.Foreground = color;

                var dayOfWeek = DateTime.Now.DayOfWeek;

                e.Handled = dayOfWeek != DayOfWeek.Saturday ||
                    dayOfWeek != DayOfWeek.Sunday;
            }
        }

        private Brush GenerateColor(int p1, int p2)
        {
            var random = new Random();

            var brush = new SolidColorBrush(
                Color.FromRgb(
                    (byte)random.Next(p1, p2),
                    (byte)random.Next(p1, p2),
                    (byte)random.Next(p1, p2)));

            return brush;
        }

        private void HandleTextChangedAtWindow(object sender, TextChangedEventArgs e)
        {
            var source = e.OriginalSource as TextBox;

            if (source != default(TextBox))
            {
                var color = GenerateColor(0, 100);

                source.Background = color;
            }
        }

        private void HandlePreviewMouseDownAtButton(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PMD @ Button!");
        }

        private void HandlePreviewMouseDownAtGrid(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PMD @ Grid!");
        }

        private void HandlePreviewMouseDownAtWindow(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PMD @ Window!");
        }

        private void HandleMouseDownAtGrid(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MD @ Grid!");
        }
    }
}

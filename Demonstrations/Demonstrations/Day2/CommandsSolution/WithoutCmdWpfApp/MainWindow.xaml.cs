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

namespace WithoutCmdWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.I && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
                ImportData();
            else if (e.Key == Key.E && e.KeyboardDevice.Modifiers == ModifierKeys.Control)
                ExportData();
        }

        private void ExportData(object sender=default(object), RoutedEventArgs eventArgs=default(RoutedEventArgs))
        {
            MessageBox.Show("Export Data Completed!");
        }

        private void ImportData(object sender = default(object), RoutedEventArgs eventArgs = default(RoutedEventArgs))
        {
            MessageBox.Show("Import Data Completed!");
        }
    }
}

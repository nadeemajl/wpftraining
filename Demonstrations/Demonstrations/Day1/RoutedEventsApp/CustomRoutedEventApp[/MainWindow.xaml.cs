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

namespace CustomRoutedEventApp_
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

        private void SearchPanel_SearchInitiated(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Search Initiated Handled At Search Panel ... " + e.ToString());
        }

        private void Grid_SearchInitiated(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Search Initiated Handled At Grid ... " + e.ToString());
        }

        private void Window_SearchInitiated(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Search Initiated Handled At Window ... " + e.ToString());
        }
    }
}

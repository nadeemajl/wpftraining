using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIVirtualizationWPFApp.ModelServices;

namespace UIVirtualizationWPFApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            var customers = CustomerService.GetCustomers();
            watch.Stop();

            MessageBox.Show(string.Format(@"Totally # {0} ms taken to load customers data!",
                watch.ElapsedMilliseconds.ToString()));

            this.cbCustomers.DisplayMemberPath = "Name";
            this.cbCustomers.ItemsSource = customers;
        }
    }
}

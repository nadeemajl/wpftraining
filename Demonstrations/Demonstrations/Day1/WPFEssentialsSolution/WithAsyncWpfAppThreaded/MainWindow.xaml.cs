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
using WithoutAsyncWpfApp.Models;
using WithoutAsyncWpfApp.ModelServices;

namespace WithoutAsyncWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.customersFuncObject = CustomerService.GetCustomers;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            this.customersFuncObject.BeginInvoke(
                new AsyncCallback(
                    result =>
                    {
                        var customers = customersFuncObject.EndInvoke(result);

                        Dispatcher.BeginInvoke(
                            new Action(() =>
                            {
                                this.dgResults.AutoGenerateColumns = true;
                                this.dgResults.ItemsSource = customers;
                            }));
                    }), default(object));
        }

        private Func<IEnumerable<Customer>> customersFuncObject = default(Func<IEnumerable<Customer>>);
    }
}

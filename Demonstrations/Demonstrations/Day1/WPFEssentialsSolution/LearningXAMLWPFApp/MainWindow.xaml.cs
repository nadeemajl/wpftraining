using CRMSystemLibrary;
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

namespace LearningXAMLWPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleShowDetails(object sender, RoutedEventArgs e)
        {
            var companyName = this.Resources["companyName"] as string;

            if (!string.IsNullOrEmpty(companyName))
                MessageBox.Show("Company Name : " + companyName);

            var customer = this.Resources["customer"] as Customer;

            if (customer != default(Customer))
                MessageBox.Show(string.Format(@"Customer Details : {0}",
                    customer.ToString()));
        }
    }
}

using GS.Libraries.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GS.Apps.OrderSystem
{
    public partial class App : Application
    {
        private void HandleApplicationStartup(object sender, StartupEventArgs e)
        {
            var orderSystemDashboardView = new OrderSystemDashboardView();

            Application.Current.MainWindow = orderSystemDashboardView;
            Application.Current.MainWindow.Show();
        }
    }
}

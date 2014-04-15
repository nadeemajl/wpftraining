using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Xml;

namespace DynamicUI
{
    public partial class App : Application
    {
        private void HandleApplicationStartup(object sender, StartupEventArgs e)
        {
            var viewFileName = @"MainWindow.xaml";
            var view = XamlReader.Load(
                XmlReader.Create(File.OpenRead(viewFileName),
                new XmlReaderSettings
                {
                    CheckCharacters = true,
                    ConformanceLevel = ConformanceLevel.Auto,
                    IgnoreComments = true,
                    IgnoreProcessingInstructions = true,
                    IgnoreWhitespace = true,
                    ValidationType = ValidationType.None
                })) as Window;

            if (view != default(Window))
            {
                Application.Current.MainWindow = view;
                Application.Current.MainWindow.Show();
            }
        }
    }
}
